using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private int _demage = 5;
    [SerializeField] private Health _health;
    
    public void DealDamage()
    {
        _health.TakeDamage(_demage);
    }
}