using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private Vector3 moveDirection;

    public void Setup(Vector3 direction)
    {
        moveDirection = direction;
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
