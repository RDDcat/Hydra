using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToWorld : MonoBehaviour
{
    public GameObject prefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;
            //if(Physics.Raycast(ray, out hit))
            //{
            //    Instantiate(prefab, hit.point, Quaternion.identity);
            //}
            //마우스 클릭해서 오브젝트 생성하기
            Vector3 mP = Input.mousePosition + Vector3.forward;
            Vector3 target = Camera.main.ScreenToWorldPoint(mP);
            Instantiate(prefab,target, Quaternion.identity);
        }
    }
}
