using UnityEngine;

public class HealthButton : MonoBehaviour
{
    [SerializeField] private int _heal = 15;
    [SerializeField] private Health _health;
    
    public void PerformHealing()
    {
        _health.HealPlayer(_heal);
    }
}