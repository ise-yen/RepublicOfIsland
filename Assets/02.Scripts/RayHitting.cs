using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHitting : MonoBehaviour
{
    public static RayHitting instance;

    public RaycastHit hit; //충돌 감지
    public Ray ray;

    GameObject selectObject; //클릭한 오브젝트
    public GameObject SelectObj {
        get { return selectObject;  }
        set { selectObject = value; }
    } //선택한 블럭

    public float dist;

    private OutlineController prevController;
    private OutlineController currentController;


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
    private void Update()
    {
        HandleLookAtRay();

        if(Input.GetMouseButtonDown(1))
        {
            ClickObject();
        }
    }


    public void ClickObject()
    {
        //SelectObj = null;
        //마우스의 위치를 레이로 변환
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //레이 발사
        if (Physics.Raycast(ray, out hit))
        {
            SelectObj = hit.collider.gameObject;
            hit.transform.GetComponent<Building>().SpawnEventPage();
        }
    }
    private void HandleLookAtRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, dist))
        {
            if (hit.collider.CompareTag("Interact"))
            {
                currentController = hit.collider.GetComponent<OutlineController>();

                if (prevController != currentController)
                {
                    HideOutline();
                    ShowOutline();
                }

                prevController = currentController;
            }
            else
            {
                HideOutline();
            }
        }
        else
        {
            HideOutline();
        }
    }

    private void ShowOutline()
    {
        if (currentController != null)
        {
            currentController.ShowOutline();
        }
    }

    private void HideOutline()
    {
        if (prevController != null)
        {
            prevController.HideOutline();
            prevController = null;
        }
    }
}
