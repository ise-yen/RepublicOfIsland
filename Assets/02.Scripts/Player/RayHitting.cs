using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHitting : MonoBehaviour
{
    RaycastHit hit; //충돌 감지
    Ray ray;

    float MaxRayDistance = 100f; //Ray의 거리(길이)

    void Start()
    {
    }

    void Update()
    {
        ClickObject();
    }

    void ClickObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("================================");
                Debug.Log("Object Name : " + hit.collider.gameObject.name);
                //Debug.Log("ray hit Diastance : " + hit.distance);
                //Debug.Log("ray hit Normal : " + hit.normal);
                //Debug.Log("Object Transform : " + hit.transform.position);
            }
        }
    }

}
