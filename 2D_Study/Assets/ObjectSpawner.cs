using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    private void Awake()
    {
        //Instantiate(���� ������Ʈ,��ġ,ȸ��)
        //��ġ�� ���� ������ �Ұ����ϰ� 3���� �Ű������� ����ؾ� �Ѵ�
        //Quaternion.identity : no change
        //Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        //Instantiate(boxPrefab, new Vector3(-1, -2, 0), Quaternion.identity);

        //ȸ���ϴ� ��� 1.Euler 2. Quaternion
        //Quaternion rotation = Quaternion.Euler(0, 0, 10);
        
        //GameObject clone = Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);
        //clone.name = "Box001";//�̸� ����
        //clone.GetComponent<SpriteRenderer>().color = Color.black;//���� ����
        //clone.transform.position = new Vector3(2, 1, 0);//��ġ ����
        //clone.transform.localScale = new Vector3(3, 2, 1);//ũ�� ����

        //�ݺ� ����
        //for(int i = 0; i < 10; i++)
        //{
        //    Quaternion rotation = Quaternion.Euler(0, 0, 9*i);
        //    Instantiate(boxPrefab, new Vector3(-5 + i, 0, 0), rotation);
        //}

        //���߹ݺ���
        for(int y = 0; y < 10; ++ y)
        {
            for(int x = 0; x < 10; ++ x)
            {
                //if(x == y || x+y == 9)
                if(x+y == 4 || x+y == 5)
                {
                    continue;
                }
                Instantiate(boxPrefab, new Vector3(-4.5f+ x, 4.5f - y, 0), Quaternion.identity);
            }
        }
    }
}
