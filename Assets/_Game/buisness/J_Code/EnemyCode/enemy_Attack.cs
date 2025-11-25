using UnityEngine;

public class enemy_Attack : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<P_Health>().takeDamage(damage);
        }
    }
}
