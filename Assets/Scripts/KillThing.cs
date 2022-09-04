using UnityEngine;
using UnityEngine.Events;

public class KillThing : MonoBehaviour
{
    public UnityEvent triggerEnter;

    private void OnTriggerEnter(Collider other)
    {
        var otherDamageable = other.GetComponentInChildren<Damageable>();
        if (otherDamageable != null)
        {
            otherDamageable.isAlive = false;
        }
    }
}
