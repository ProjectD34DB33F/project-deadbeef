using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int currentHp { get; private set; }
    public Stat maxHp;
    public int currentMp { get; private set; }
    public Stat maxMp;

    private void Awake()
    {
        currentHp = maxHp.GetValue();
        currentMp = maxMp.GetValue();
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");
        Debug.Log("Current HP: " + currentHp);

        if (currentHp <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //What to do when player dies
    }
}