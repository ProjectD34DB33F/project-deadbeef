using UnityEngine;
using UnityEngine.UI;

public class ResourceBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Text textRe;

    public void SetMaxResource(int resource)
    {
        slider.maxValue = resource;
        slider.value = resource;
        textRe.text = resource + " / " + resource;
    }

    public void SetResource(int currentRe, int maxRe)
    {
        slider.value = currentRe;
        textRe.text = currentRe + " / " + maxRe;
    }
}
