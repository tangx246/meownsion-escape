using StarterAssets;
using UnityEngine;

public class PlayerStompHurtbox : MonoBehaviour
{
    public Collider collide;
    public ThirdPersonController controller;

    private void Awake()
    {
        collide = GetComponent<Collider>();
        controller = transform.parent.GetComponentInChildren<ThirdPersonController>();
    }

    private void Update()
    {
        collide.enabled = !controller.Grounded;
    }
}
