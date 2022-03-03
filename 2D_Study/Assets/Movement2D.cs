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
        //낮은 점프, 높은 점프 구현을 위한 중력 계수(gravityScale) 조절(Jump Up일 때만 적용)
        //중력 계수가 낮은 if문은 높은 점프가 되고, 중력 계수가 높은 else문은 낮은 점프가 된다
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
        // x축 이동은 x * speed, y축 이동은 기존의 속력값(== 현재는 중력)
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        //jumpForce의 크기만큼 윗쪽 방향으로 속력 설정
        rigid2D.velocity = Vector2.up * jumpForce;
    }
}
