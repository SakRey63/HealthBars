using TMPro;
using UnityEngine;

public class HealthPlayerText : HealthViu
{
    private const string DirectSlash = " / ";
    
    [SerializeField] private TextMeshProUGUI _playerHealthText;
    [SerializeField] private TextMeshProUGUI _maxHealthText;

    private int _goodHealth = 70;
    private int _badHealth = 30;
    private int _maxHealth = 100;

    private void Start()
    {
        BringMaxHealth();
    }

    protected override void ChangeHealthPlayer(float health)
    {
        _playerHealthText.color = ChangeColor(health);

        _playerHealthText.text = health.ToString();
    }

    private void BringMaxHealth()
    {
        _maxHealthText.color = ChangeColor(_maxHealth);
        
        _maxHealthText.text = DirectSlash + _maxHealth.ToString();
    }
}