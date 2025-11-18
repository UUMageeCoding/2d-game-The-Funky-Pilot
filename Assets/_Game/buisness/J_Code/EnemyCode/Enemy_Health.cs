using UnityEngine;

public class Enemy_Health : MonoBehaviour, IDamagable
{
    [SerializeField] private float Maxhealth = 3f;

    private float CurrentHealth;

    private void Start()
    {
        CurrentHealth = Maxhealth;
    }

    public void Damage(float damageAmount)
    {
        CurrentHealth -= damageAmount;

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
    
    private void Die()
    {
        Destroy(gameObject);
    }
}
