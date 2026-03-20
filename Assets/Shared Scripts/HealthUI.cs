using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public EnemyHealth enemyHealth;

    public TextMeshProUGUI playerHealthText;
    public TextMeshProUGUI enemyHealthText;

    void Update()
    {
        if (playerHealth != null)
        {
            playerHealthText.text = "Player: " + playerHealth.health;
        }

        if (enemyHealth != null)
        {
            enemyHealthText.text = "Enemy: " + enemyHealth.health;
        }
        else
        {
            enemyHealthText.text = "Enemy: 0";
        }
    }
}
