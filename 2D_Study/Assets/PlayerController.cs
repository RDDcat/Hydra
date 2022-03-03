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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }

        //if press space player can jump high
        if(Input.GetKey(KeyCode.Space))
        {
            movement2D.isLongJump = true;
        }
        //if don't press space player can jump low
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            movement2D.isLongJump = false;
        }
    }
}
