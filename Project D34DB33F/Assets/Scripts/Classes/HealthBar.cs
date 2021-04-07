using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Text textHp;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        textHp.text = health + " / " + health;
    }

    public void SetHealth(int currentHP, int maxHP)
    {
        slider.value = currentHP;
        textHp.text = currentHP + " / " + maxHP;
    }
}
