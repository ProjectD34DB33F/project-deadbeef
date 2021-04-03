using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int currentHp { get; private set; }
    public Stat maxHp;
    public int currentRe { get; private set; }
    public Stat maxRe;

    [SerializeField] HealthBar healthBar;
    [SerializeField] ResourceBar resourceBar;

    private void Awake()
    {
        currentHp = maxHp.GetValue();
        healthBar.SetMaxHealth(maxHp.GetValue());
        healthBar.SetHealth(currentHp);

        currentRe = maxRe.GetValue();
        resourceBar.SetMaxResource(maxRe.GetValue());
        resourceBar.SetResource(currentRe);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");
        Debug.Log("Current HP: " + currentHp);
        healthBar.SetHealth(currentHp);

        if (currentHp <= 0)
        {
            Die();
        }
    }

    public void UseAbility(int resource)
    {
        currentRe -= resource;
        resourceBar.SetResource(currentRe);

        if (currentRe <= 0)
        {
            currentRe = maxRe.GetValue();
        }
    }

    public virtual void Die()
    {
        //What to do when player dies
    }
}