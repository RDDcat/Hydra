using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    //[SerializeField] 해당 변수 바로 윗줄에 작성. Inspector View에서 변수의 옵션 조절할 수 있게 해줌.
    [SerializeField]
    private Color color;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //총돌이 일어나는 순간 1회 호출
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Q. 투명으로 변하는 오류 발생
        //A. Color에서 A값 0 -> 255로 변경
        spriteRenderer.color = color;
    }

    //충돌이 유지되는 동안 매 프레임 호출
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " : OnCollisionStay2D() 메소드 실행");
    }

    //충돌이 종료되는 순간 1회 호출
    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}
