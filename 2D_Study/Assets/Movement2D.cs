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

        //새로운 위치 = 현재 위치 + (방향 * 속도)
        //transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Rigidbody2D 컴포넌트에 있는 속력(velocity) 변수 설정
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
    }
}
