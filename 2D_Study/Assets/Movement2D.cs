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

    [SerializeField]
    private LayerMask groundLayer;//�ٴ� üũ�� ���� �浹 ���̾�
    private CapsuleCollider2D capsuleCollider2D;//������Ʈ�� �浹 ���� ������Ʈ
    private bool isGrounded;//�ٴ�üũ(�ٴڿ� ������� �� true)
    private Vector3 footPosition;// ���� ��ġ

    [SerializeField]
    private int maxJumpCount = 2;
    private int currentJumpCount = 0;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }

    private void FixedUpdate()
    {
        //player object's Collider2D min, center, max location information
        Bounds bounds = capsuleCollider2D.bounds;
        //player footposition location setting
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        //create invisible circle in location of player footposition if circle hit the floor, isGrounded = true
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);

        //if player is on ground And velocity of y is under 0
        //if don't add 'velocity.y <= 0' condition, can jump three times
        //if(isGrounded == true)
        if(isGrounded == true && rigid2D.velocity.y <= 0)
        {
            currentJumpCount = maxJumpCount;
        }

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

    private void OnDrawGizmos()
    {
        //Gizmos : ������ �ʴ� ���̳� �ڽ��� �� �� �ְ� ������ �ִ� �Լ�
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(footPosition, 0.1f);
    }

    public void Move(float x)
    {
        // x�� �̵��� x * speed, y�� �̵��� ������ �ӷ°�(== ����� �߷�)
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        //if (isGrounded == true)
        if(currentJumpCount > 0)
        {
            //jumpForce�� ũ�⸸ŭ ���� �������� �ӷ� ����
            rigid2D.velocity = Vector2.up * jumpForce;

            currentJumpCount -= 1;
        }
    }
}
