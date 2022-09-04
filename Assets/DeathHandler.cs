using StarterAssets;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public Damageable damageable;
    public CharacterController controller;
    public ThirdPersonController controller2;
    public Animator animator;

    private void Awake()
    {
        damageable = GetComponent<Damageable>();
        controller = GetComponent<CharacterController>();
        controller2 = GetComponent<ThirdPersonController>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        damageable.isAliveUpdated.AddListener(HandleDeath);
    }

    private void HandleDeath()
    {
        controller.enabled = false;
        controller2.enabled = false;
        animator.enabled = false;
    }
}
