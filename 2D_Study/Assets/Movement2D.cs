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
        // x축 이동은 x * speed, y축 이동은 기존의 속력값(== 현재는 중력)
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        //jumpForce의 크기만큼 윗쪽 방향으로 속력 설정
        rigid2D.velocity = Vector2.up * jumpForce;
    }
}
