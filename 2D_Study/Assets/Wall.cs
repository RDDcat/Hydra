using System.Collections;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���� �ε��� ������Ʈ ����
        Destroy(collision.gameObject);
        //�浹 �� ���� ������ ��� ����
        //https://docs.unity3d.com/kr/530/Manual/Coroutines.html
        StartCoroutine("HitAnimation");
    }

    private IEnumerator HitAnimation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);
        
        spriteRenderer.color = Color.white;
    }
}
