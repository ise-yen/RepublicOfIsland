using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHitting : MonoBehaviour
{
    public static RayHitting instance;
    
    public RaycastHit hit; //충돌 감지
    public Ray ray;
    private GameObject SelectObject; //클릭한 오브젝트
    
    //클릭한 오브젝트를 다른 스크립트에서 접근 가능하도록 세팅
    public GameObject SelectObj {
        get { return SelectObject; }
        set { SelectObject = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }

    //오브젝트 클릭
    public void ClickObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //마우스의 위치를 레이로 변환
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //레이 발사
            if (Physics.Raycast(ray, out hit))
            {
                SelectObject = hit.collider.gameObject;
                Debug.Log("--------------------------------");
                Debug.Log("Object Name : " + hit.collider.gameObject.name);
            }
        }
    }
}
