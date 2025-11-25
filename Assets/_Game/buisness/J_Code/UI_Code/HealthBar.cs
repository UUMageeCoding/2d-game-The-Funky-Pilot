using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private P_Health playerhealth;
    [SerializeField] private Image totalhealthbar;
    [SerializeField] private Image currenthealtbar;

    private void Start()
    {
        totalhealthbar.fillAmount = playerhealth.curretPHealth / 10;
    }

    private void Update()
    {
        currenthealtbar.fillAmount = playerhealth.curretPHealth / 10;
    }
}
