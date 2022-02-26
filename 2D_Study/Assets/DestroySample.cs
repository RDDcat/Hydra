using UnityEngine;

public class DestroySample : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

    private void Awake()
    {
        //playerObject�� PlayerController ������Ʈ ����
        //Destroy(playerObject.GetComponent<PlayerController>());

        //playerObject ���ӿ�����Ʈ ����
        //Destroy(playerObject);

        //playerObject ���ӿ�����Ʈ 2�� �� ����
        Destroy(playerObject, 2.0f);
    }
}
