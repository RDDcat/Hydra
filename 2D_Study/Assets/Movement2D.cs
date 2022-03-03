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
    private LayerMask groundLayer;//바닥 체크를 위한 충돌 레이어
    private CapsuleCollider2D capsuleCollider2D;//오브젝트의 충돌 범위 컴포넌트
    private bool isGrounded;//바닥체크(바닥에 닿아있을 때 true)
    private Vector2 footPosition;// 발의 위치

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

    private void OnDrawGizmos()
    {
        //Gizmos : 보이지 않는 선이나 박스를 볼 수 있게 변경해 주는 함수
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(footPosition, 0.1f);
    }

    public void Move(float x)
    {
        // x축 이동은 x * speed, y축 이동은 기존의 속력값(== 현재는 중력)
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        if (isGrounded == true)
        {
            //jumpForce의 크기만큼 윗쪽 방향으로 속력 설정
            rigid2D.velocity = Vector2.up * jumpForce;
        }
    }
}
