using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float jumpForce = 8.0f; //jump force. if it bigger can jump high.
    private Rigidbody2D rigid2D;
    [HideInInspector]
    public bool isLongJump = false; //jump low or high check

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //���� ����, ���� ���� ������ ���� �߷� ���(gravityScale) ����(Jump Up�� ���� ����)
        //�߷� ����� ���� if���� ���� ������ �ǰ�, �߷� ����� ���� else���� ���� ������ �ȴ�
        if(isLongJump && rigid2D.velocity.y > 0)
        {
            rigid2D.gravityScale = 1.0f;
        }
        else
        {
            rigid2D.gravityScale = 2.5f;
        }
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
