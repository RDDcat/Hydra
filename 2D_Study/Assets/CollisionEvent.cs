using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    //[SerializeField] �ش� ���� �ٷ� ���ٿ� �ۼ�. Inspector View���� ������ �ɼ� ������ �� �ְ� ����.
    [SerializeField]
    private Color color;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //�ѵ��� �Ͼ�� ���� 1ȸ ȣ��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Q. �������� ���ϴ� ���� �߻�
        //A. Color���� A�� 0 -> 255�� ����
        spriteRenderer.color = color;
    }

    //�浹�� �����Ǵ� ���� �� ������ ȣ��
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " : OnCollisionStay2D() �޼ҵ� ����");
    }

    //�浹�� ����Ǵ� ���� 1ȸ ȣ��
    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}
