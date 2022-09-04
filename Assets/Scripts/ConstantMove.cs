using UnityEngine;

public class ConstantMove : MonoBehaviour
{
    public Vector3 directionAndRate;

    void Update()
    {
        transform.position += directionAndRate * Time.deltaTime;
    }
}
