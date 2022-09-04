using UnityEngine;

public class LockAxis : MonoBehaviour
{
    public float value;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, value);
    }
}
