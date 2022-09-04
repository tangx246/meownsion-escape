using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    public LayerMask hurtLayer;

    private void OnTriggerEnter(Collider other)
    {
        if ((hurtLayer & (1 << other.gameObject.layer)) != 0)
        {
            var damageable = other.gameObject.GetComponentInChildren<Damageable>();
            if (damageable != null)
            {
                damageable.isAlive = false;
            }
        }
    }
}