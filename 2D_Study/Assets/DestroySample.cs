using UnityEngine;

public class DestroySample : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

    private void Awake()
    {
        //playerObject의 PlayerController 컴포넌트 삭제
        //Destroy(playerObject.GetComponent<PlayerController>());

        //playerObject 게임오브젝트 삭제
        //Destroy(playerObject);

        //playerObject 게임오브젝트 2초 후 삭제
        Destroy(playerObject, 2.0f);
    }
}
