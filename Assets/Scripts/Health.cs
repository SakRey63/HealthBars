using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 100;

    private float _maxHealth = 100;
    private float _dead = 0;
    private bool _isDead = false;
    private bool _isHeal = false;
    
    public event Action<float> HPChanged;
    
    private void Start()
    {
        HPChanged?.Invoke(_health);
    }
    
    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health <= _dead)
        {
            _health = _dead;
            
            _isDead = true;
        }
        
        HPChanged?.Invoke(_health);
    }
    
    public void HealPlayer(float heal)
    {
        if (_health < _maxHealth && heal > _dead && _isDead == false)
        {
            _isHeal = true;
            
            _health += heal;

            if (_health > _maxHealth)
            {
                _health = _maxHealth;
            }
            
            HPChanged?.Invoke(_health);
        }
    }
}