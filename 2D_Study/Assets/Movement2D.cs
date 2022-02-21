using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private void Awake()
    {
        // new position = now + (vector*speed)
        transform.position = transform.position + new Vector3(1, 0, 0) * 1;
        // transform.position += Vector3.right * 1;
    }
}
