using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    public bool isAlive { get { return _isAlive; } set { _isAlive = value; isAliveUpdated.Invoke(); } }
    [SerializeField] private bool _isAlive;
    public UnityEvent isAliveUpdated = new();
}
