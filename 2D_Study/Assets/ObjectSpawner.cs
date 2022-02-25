using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    private void Awake()
    {
        //Instantiate(원본 오브젝트,위치,회전)
        //위치만 따로 설정은 불가능하고 3개의 매개변수를 사용해야 한다
        //Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        //Instantiate(boxPrefab, new Vector3(-1, -2, 0), Quaternion.identity);

        //회전하는 방식 1.Euler 2. Quaternion
        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        
        GameObject clone = Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);
        clone.name = "Box001";//이름 변경
        clone.GetComponent<SpriteRenderer>().color = Color.black;//색상 변경
        clone.transform.position = new Vector3(2, 1, 0);//위치 변경
        clone.transform.localScale = new Vector3(3, 2, 1);//크기 변경
    }
}
