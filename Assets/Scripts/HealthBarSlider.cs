using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : HealthView
{
    [SerializeField] private Slider _slider;
    
    protected override void ChangeHealthPlayer(float health)
    {
        CreateColor(health);
        
        _slider.value = health;
    }

    private void CreateColor(float health)
    {
        _slider.fillRect.TryGetComponent(out Image image);

        image.color = ChangeColor(health);
    }
}