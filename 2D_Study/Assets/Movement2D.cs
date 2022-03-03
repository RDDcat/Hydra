using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float jumpForce = 8.0f;
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    public void Move(float x)
    {
        // x�� �̵��� x * speed, y�� �̵��� ������ �ӷ°�(== ����� �߷�)
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        //jumpForce�� ũ�⸸ŭ ���� �������� �ӷ� ����
        rigid2D.velocity = Vector2.up * jumpForce;
    }
}
