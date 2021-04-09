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
        healthBar.SetHealth(currentHp, maxHp.GetValue());

        currentRe = maxRe.GetValue();
        resourceBar.SetMaxResource(maxRe.GetValue());
        resourceBar.SetResource(currentRe, maxRe.GetValue());
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");
        Debug.Log("Current HP: " + currentHp);
        healthBar.SetHealth(currentHp, maxHp.GetValue());

        if (currentHp <= 0)
        {
            Die();
        }
    }

    public void UseAbility(int resource)
    {
        if (currentRe == maxRe.GetValue())
        {
            InvokeRepeating("GainRe", 0.0f, 0.5f);
        }       

        currentRe -= resource;
        resourceBar.SetResource(currentRe, maxRe.GetValue());

        if (currentRe <= 0)
        {
            currentRe = 0;
        }
    }

    public void GainRe()
    {
        if (currentRe < maxRe.GetValue())
        {            
            currentRe += 1;
            Debug.Log(transform.name + " gains " + 1 + " MP.");
            Debug.Log("Current MP: " + currentRe);
            if (currentRe > maxRe.GetValue())
            {
                currentRe = maxRe.GetValue();
            }
            resourceBar.SetResource(currentRe, maxRe.GetValue());
        }
        if (currentRe == maxRe.GetValue())
        {
            CancelInvoke("GainRe");
        }
    }

    public virtual void Die()
    {
        //What to do when character dies
    }
}