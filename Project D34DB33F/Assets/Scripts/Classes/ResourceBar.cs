using UnityEngine;
using UnityEngine.UI;

public class ResourceBar : MonoBehaviour
{
    [SerializeField] Slider slider;

    [SerializeField] Text textRe = null;

    private void Start()
    {
        
    }

    public void SetMaxResource(int resource)
    {
        slider.maxValue = resource;
        slider.value = resource;

        if (textRe != null)
        {
            textRe.text = resource + " / " + resource;
        }
    }

    public void SetResource(int currentRe, int maxRe)
    {
        slider.value = currentRe;

        if (textRe != null)
        {
            textRe.text = currentRe + " / " + maxRe;
        }
    }
}
