using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Text textHp = null;

    private void Awake()
    {
        
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        if (textHp != null)
        {
            textHp.text = health + " / " + health;
        }
    }

    public void SetHealth(int currentHP, int maxHP)
    {
        slider.value = currentHP;

        if (textHp != null)
        {
            textHp.text = currentHP + " / " + maxHP;
        }
    }
}