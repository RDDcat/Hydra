using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    private void Awake()
    {
        //Instantiate(���� ������Ʈ,��ġ,ȸ��)
        //��ġ�� ���� ������ �Ұ����ϰ� 3���� �Ű������� ����ؾ� �Ѵ�
        //Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        //Instantiate(boxPrefab, new Vector3(-1, -2, 0), Quaternion.identity);

        //ȸ���ϴ� ��� 1.Euler 2. Quaternion
        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        
        GameObject clone = Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);
        clone.name = "Box001";//�̸� ����
        clone.GetComponent<SpriteRenderer>().color = Color.black;//���� ����
        clone.transform.position = new Vector3(2, 1, 0);//��ġ ����
        clone.transform.localScale = new Vector3(3, 2, 1);//ũ�� ����
    }
}
