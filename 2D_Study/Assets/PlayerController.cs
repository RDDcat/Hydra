using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D movement2D;

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
    }

    private void Update()
    {
        //left or a = -1, right or d = 1
        float x = Input.GetAxisRaw("Horizontal");
        //좌우 이동 방향 제어
        movement2D.Move(x);

        //플레이어 점프(스페이스키)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
    }
}
