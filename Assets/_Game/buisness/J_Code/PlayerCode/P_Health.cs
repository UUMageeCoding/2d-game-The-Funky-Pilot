using UnityEngine;

public class P_Health : MonoBehaviour
{
    [SerializeField] private float startHealth;
    public float curretPHealth { get; private set; }

    private void Awake()
    {
        curretPHealth = startHealth;
    }

    public void takeDamage(float _damage)
    {
        curretPHealth = Mathf.Clamp(curretPHealth - _damage, 0, startHealth);

        if (curretPHealth > 0)
        {
            //damage
        }
        else
        {
            //die
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            takeDamage(3);
    }

}
