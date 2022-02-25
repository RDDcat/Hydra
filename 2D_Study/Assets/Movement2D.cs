using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //move left, right
        float y = Input.GetAxisRaw("Vertical"); //move up, down

        //���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
        //transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Rigidbody2D ������Ʈ�� �ִ� �ӷ�(velocity) ���� ����
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
    }
}
