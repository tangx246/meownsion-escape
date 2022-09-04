using UnityEngine;
using UnityEngine.AI;

public class Patroller : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] waypoints;
    public int currentWaypoint = 0;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        GoNext();
    }

    private void Update()
    {
        if (agent.remainingDistance <= 0.1f)
        {
            GoNext();
        }
    }

    private void GoNext()
    {
        agent.destination = waypoints[currentWaypoint].position;
        currentWaypoint = (currentWaypoint + 1) % waypoints.Length;
    }
}
