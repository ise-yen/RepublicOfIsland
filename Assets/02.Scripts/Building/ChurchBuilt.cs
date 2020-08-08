using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchBuilt : MonoBehaviour
{
    //건설에 사용되는 재화 종류
    public int brikits = 1000; //브리킷
    public int administrativePowers = 2000; //행정력
    public int foods = 10; //식량

    //건물을 담을 오브젝트
    public GameObject FirstChurch;
    public GameObject SecondChurch;
    public GameObject ThirdChurch;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BuildFirstChurch();
            BuildSecondChurch();
            BuildThirdChurch();
            Debug.Log("교회 생성 완료");
        }
    }

    public void BuildFirstChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "ChurchPlane")
        {
            brikits = brikits - 125;
            administrativePowers = administrativePowers - 400;
            foods = foods - 1;
            Debug.Log("잔여 브리킷: " + brikits);
            Debug.Log("잔여 행정력: " + administrativePowers);
            Debug.Log("잔여 식량: " + foods);
            FirstChurch.SetActive(true);
            Debug.Log("1단계 교회 생성");
        }
    }
    public void BuildSecondChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "Church1")
        {
            brikits = brikits - 250;
            administrativePowers = administrativePowers - 600;
            foods = foods - 3;
            Debug.Log("잔여 브리킷: " + brikits);
            Debug.Log("잔여 행정력: " + administrativePowers);
            Debug.Log("잔여 식량: " + foods);
            FirstChurch.SetActive(false);
            SecondChurch.SetActive(true);
            Debug.Log("2단계 교회 생성");
        }
    }
    public void BuildThirdChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "Church2")
        {
            brikits = brikits - 500;
            administrativePowers = administrativePowers - 800;
            foods = foods - 5;
            Debug.Log("잔여 브리킷: " + brikits);
            Debug.Log("잔여 행정력: " + administrativePowers);
            Debug.Log("잔여 식량: " + foods);
            SecondChurch.SetActive(false);
            ThirdChurch.SetActive(true);
            Debug.Log("3단계 교회 생성");
        }
    }
}