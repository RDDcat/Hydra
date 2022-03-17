using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightMove: MonoBehaviour
{
    //private Vector3 defaultpos = new Vector3(950, 300, 0);

    //void Start()
    //{
    //    //transform.position = Input.mousePosition;
    //}

    //void Update()
    //{
    //    transform.position = Input.mousePosition - defaultpos;

    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Debug.Log("pang!!");
    //    }
    //}
    public GameObject sight;
    //private float initialZPos = 0f;

    /*void Awake()
    {
    initialZPos = followingCube.transform.position.y;
    }*/

    void Update()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        sight.transform.position = new Vector3(newPosition.x, sight.transform.position.y, newPosition.z);

        print("X : " + newPosition.x + ", Y : " + newPosition.y + ", Z : " + newPosition.z);

    }
}
