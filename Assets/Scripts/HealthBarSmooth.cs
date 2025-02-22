using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : HealthViu
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed = 70f;

    protected override void ChangeHealthPlayer(float health)
    {
        StartCoroutine(ChangeSmoothlyHealth(health));
    }

    private IEnumerator ChangeSmoothlyHealth(float health)
    {
        while (_slider.value < health || _slider.value > health)
        { 
            _slider.value = Mathf.MoveTowards(_slider.value, health, _speed * Time.deltaTime);
            
            CreateColor(health);
            
            yield return null;
        }
    }
    
    private void CreateColor(float health)
    {
        _slider.fillRect.TryGetComponent(out Image image);

        image.color = ChangeColor(health);
    }
}