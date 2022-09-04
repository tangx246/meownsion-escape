using UnityEngine;
using UnityEngine.Events;

public class Victory : MonoBehaviour
{
    public LayerMask victoryLayer;
    public UnityEvent victoryEvent;

    private void OnTriggerEnter(Collider other)
    {
        if ((victoryLayer & (1 << other.gameObject.layer)) != 0)
        {
            victoryEvent.Invoke();
        }
    }
}
