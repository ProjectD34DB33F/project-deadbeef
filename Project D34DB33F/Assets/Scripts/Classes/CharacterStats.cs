using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int currentHp { get; private set; }
    public Stat maxHp;
    public int currentRe { get; private set; }
    public Stat maxRe;

    [SerializeField] HealthBar healthBar;
    [SerializeField] ResourceBar resourceBar = null;

    private void Awake()
    {
        currentHp = maxHp.GetValue();
        healthBar.SetMaxHealth(maxHp.GetValue());
        healthBar.SetHealth(currentHp, maxHp.GetValue());

        if (resourceBar != null)
        {
            currentRe = maxRe.GetValue();
            resourceBar.SetMaxResource(maxRe.GetValue());
            resourceBar.SetResource(currentRe, maxRe.GetValue());
        }
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        
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
            InvokeRepeating("GainRe", 2f, 0.125f);
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
        Destroy(gameObject);
    }
}