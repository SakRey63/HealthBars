using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed = 70f;
    
    private void OnEnable()
    {
        _health.HPChanged += ChangeHealthPlayer;
    }

    private void OnDisable()
    {
        _health.HPChanged -= ChangeHealthPlayer;
    }

    private void ChangeHealthPlayer(float health)
    {
        StartCoroutine(ChangeSmoothlyHealth(health));
    }

    private IEnumerator ChangeSmoothlyHealth(float health)
    {
        while (_slider.value < health || _slider.value > health)
        { 
            _slider.value = Mathf.MoveTowards(_slider.value, health, _speed * Time.deltaTime);
           
            yield return null;
        }
    }
}