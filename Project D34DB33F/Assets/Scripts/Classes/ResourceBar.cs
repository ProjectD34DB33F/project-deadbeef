using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceBar : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void SetMaxResource(int resource)
    {
        slider.maxValue = resource;
        slider.value = resource;
    }

    public void SetResource(int resource)
    {
        slider.value = resource;
    }
}
