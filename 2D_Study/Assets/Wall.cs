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
        //벽에 부딪힌 오브젝트 삭제
        Destroy(collision.gameObject);
        //충돌 시 벽의 색상을 잠시 변경
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
