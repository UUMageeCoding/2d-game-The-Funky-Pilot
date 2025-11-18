using Unity.VisualScripting;
using UnityEngine;

public class slimeAttack : MonoBehaviour
{
     [SerializeField] private Transform attackTransform;
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private LayerMask attackLayer;
    [SerializeField] private float damageAmount = 1f;
    [SerializeField] private float timeBtween = 0.15f;
    private RaycastHit2D[] hits;
    private float attackTimer;

    private void Start()
    {
        attackTimer = timeBtween;
    }
    private void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && attackTimer >= timeBtween)
        {
            attackTimer = 0f;
            Attack();
            Debug.Log("bruh");
        }

       attackTimer += Time.deltaTime;
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
