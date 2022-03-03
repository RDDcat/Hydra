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
        //�¿� �̵� ���� ����
        movement2D.Move(x);

        //�÷��̾� ����(�����̽�Ű)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
    }
}
