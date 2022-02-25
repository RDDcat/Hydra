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
        //moveObject �� ������ ���������� ����
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        //moveObject�� moveDirection �������� �̵�
        moveObject.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //������� ����
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;
        //(0,4,0)�� ��ġ
        moveObject.transform.position = new Vector3(0, 4, 0);
    }
}
