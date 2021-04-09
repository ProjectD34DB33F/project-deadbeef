using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float Health;
    public float MaxHealth;

    public GameObject HealthBarUI;
    public Slider Slider;

    private void Start()
    {
        Health = MaxHealth;
        Slider.value = CalculateHealth();
    }

    private void Update()
    {
        Slider.value = CalculateHealth();

        if (Health < MaxHealth)
        {
            HealthBarUI.SetActive(true);
        }

        if (Health <= 0)
        {
            Destroy(gameObject);
        }

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");
        Debug.Log("Current HP: " + Health);     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            TakeDamage(10);
            SoundTouched.soundTch.PlayDeathSound();
        }
    }

    float CalculateHealth()
    {
        return Health / MaxHealth;
    }

}
