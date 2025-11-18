using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform attackTransform;
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private LayerMask attackLayer;
    [SerializeField] private float damageAmount = 1f;
    private RaycastHit2D[] hits;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
    }

    private void Attack()
    {
        hits = Physics2D.CircleCastAll(attackTransform.position, attackRange, transform.right, 0f, attackLayer);

        for (int i = 0; i < hits.Length; i++)
        {
            IDamagable idamagable = hits[i].collider.gameObject.GetComponent<IDamagable>();


            if (idamagable != null)
            {
                idamagable.Damage(damageAmount);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackTransform.position, attackRange);
    }
}
