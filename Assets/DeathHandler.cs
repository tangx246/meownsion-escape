using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class DeathHandler : MonoBehaviour
{
    public Damageable damageable;
    public CharacterController controller;
    public ThirdPersonController controller2;
    public Animator animator;
    public Hurtbox hurtbox;
    public NavMeshAgent agent;
    public Patroller patroller;

    private void Awake()
    {
        damageable = GetComponent<Damageable>();
        controller = GetComponent<CharacterController>();
        controller2 = GetComponent<ThirdPersonController>();
        animator = GetComponent<Animator>();
        hurtbox = transform.parent.GetComponentInChildren<Hurtbox>();
        agent = GetComponentInChildren<NavMeshAgent>();
        patroller = GetComponentInChildren<Patroller>();
    }

    void Start()
    {
        damageable.isAliveUpdated.AddListener(HandleDeath);
    }

    private void HandleDeath()
    {
        if (controller != null)
            controller.enabled = false;
        if (controller2 != null)
            controller2.enabled = false;
        animator.enabled = false;
        hurtbox.hurtLayer = 0;
        if (agent != null)
            agent.enabled = false;
        if (patroller != null)
            patroller.enabled = false;
    }
}
