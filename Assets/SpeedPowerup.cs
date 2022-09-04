using StarterAssets;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
    public GameObject model;
    public float powerupMultiplier;

    private void Awake()
    {
        model = GetComponentInChildren<MeshRenderer>().gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        var charController = other.GetComponentInChildren<ThirdPersonController>();
        if (charController != null)
        {
            charController.MoveSpeed *= powerupMultiplier;
            charController.SprintSpeed *= powerupMultiplier;

            model.SetActive(false);
        }
    }
}
