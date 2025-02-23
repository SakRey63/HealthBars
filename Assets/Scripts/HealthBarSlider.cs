using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : HealthView
{
    [SerializeField] private Slider _slider;
    
    protected override void ChangeValue(float health)
    {
        ChangeColor(health);
        
        _slider.value = health;
    }

    private void ChangeColor(float health)
    {
        _slider.fillRect.TryGetComponent(out Image image);

        image.color = base.CreateColor(health);
    }
}