using StarterAssets;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public Damageable damageable;
    public CharacterController controller;
    public ThirdPersonController controller2;

    private void Awake()
    {
        damageable = GetComponent<Damageable>();
        controller = GetComponent<CharacterController>();
        controller2 = GetComponent<ThirdPersonController>();
    }

    void Start()
    {
        damageable.isAliveUpdated.AddListener(HandleDeath);
    }

    private void HandleDeath()
    {
        controller.enabled = false;
        controller2.enabled = false;
    }
}
