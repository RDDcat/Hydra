using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject moveObject;
    [SerializeField]
    private Vector3 moveDirection;
    private float moveSpeed;

    private void Awake()
    {
        moveSpeed = 5.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //moveObject 의 색상을 검은색으로 설정
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        //moveObject를 moveDirection 방향으로 이동
        moveObject.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //희색으로 설정
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;
        //(0,4,0)에 위치
        moveObject.transform.position = new Vector3(0, 4, 0);
    }
}
