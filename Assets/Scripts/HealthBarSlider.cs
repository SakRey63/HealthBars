using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private int _goodHealth = 70;
    private int _badHealth = 30;

    private void OnEnable()
    {
        _health.HPChanged += ChangeHealthPlayer;
    }

    private void OnDisable()
    {
        _health.HPChanged -= ChangeHealthPlayer;
    }

    private void CreateColorHealthBar(float health)
    {
        _slider.fillRect.TryGetComponent(out Image image);

        image.color = ChangeColorImage(health);
    }

    private Color ChangeColorImage(float health)
    {
        if (health > _goodHealth)
        {
            return Color.green;
        }
        else if (health > _badHealth)
        {
            return Color.yellow;
        }
        else
        {
            return Color.red;
        }
    }
    
    private void ChangeHealthPlayer(float health)
    {
        CreateColorHealthBar(health);
        
        _slider.value = health;
    }
}
