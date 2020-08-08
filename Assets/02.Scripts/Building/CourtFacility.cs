using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtFacility : MonoBehaviour
{
    //건설에 사용되는 재화 종류
    public int brikit = 1000; //브리킷
    public int administrativePower = 1000; //행정력
    public int food = 10; //식량

    //건물을 담을 오브젝트
    public GameObject FirstCourt;
    public GameObject SecondCourt;
    public GameObject ThirdCourt;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BuildFirstCourt();
            BuildSecondCourt();
            BuildThirdCourt();
        }
    }

    public void BuildFirstCourt()
    {
        RayHitting.instance.ClickObject();
        if(RayHitting.instance.SelectObj.name == "Plane")
        {
            brikit = brikit - 100;
            administrativePower = administrativePower - 250;
            food = food - 1;
            Debug.Log("잔여 브리킷: " + brikit);
            Debug.Log("잔여 행정력: " + administrativePower);
            Debug.Log("잔여 식량: " + food);
            FirstCourt.SetActive(true);
            Debug.Log("1단계 법원 생성");
        }
    }
    public void BuildSecondCourt()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "Court1")
        {
            brikit = brikit - 200;
            administrativePower = administrativePower - 450;
            food = food - 2;
            Debug.Log("잔여 브리킷: " + brikit);
            Debug.Log("잔여 행정력: " + administrativePower);
            Debug.Log("잔여 식량: " + food);
            FirstCourt.SetActive(false);
            SecondCourt.SetActive(true);
            Debug.Log("2단계 법원 생성");
        }
    }
    public void BuildThirdCourt()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "Court2")
        {
            brikit = brikit - 300;
            administrativePower = administrativePower - 600;
            food = food - 3;
            Debug.Log("잔여 브리킷: " + brikit);
            Debug.Log("잔여 행정력: " + administrativePower);
            Debug.Log("잔여 식량: " + food);
            SecondCourt.SetActive(false);
            ThirdCourt.SetActive(true);
            Debug.Log("3단계 법원 생성");
        }
    }
}