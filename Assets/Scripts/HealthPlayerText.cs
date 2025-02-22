using TMPro;
using UnityEngine;

public class HealthPlayerText : HealthView
{
    private const string DirectSlash = " / ";
    
    [SerializeField] private TextMeshProUGUI _playerHealthText;
    [SerializeField] private TextMeshProUGUI _maxHealthText;
    
    private int _maxHealth = 100;

    private void Start()
    {
        BringMaxHealth();
    }

    protected override void ChangeHealthPlayer(float health)
    {
        _playerHealthText.color = CreateColor(health);

        _playerHealthText.text = health.ToString();
    }

    private void BringMaxHealth()
    {
        _maxHealthText.color = CreateColor(_maxHealth);
        
        _maxHealthText.text = DirectSlash + _maxHealth.ToString();
    }
}