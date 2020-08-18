using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchBuilt : MonoBehaviour
{
    //건물을 담을 오브젝트
    public GameObject FirstChurch;
    public GameObject SecondChurch;
    public GameObject ThirdChurch;

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
            PlayStatManager.instance.Briket -= 125;
            KingAbilityManager.instance.AdministrativePower -= 400;
            PlayStatManager.instance.Food -= 1;

            Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
            Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
            Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);
            FirstChurch.SetActive(true);
            Debug.Log("1단계 교회 생성");
        }
    }
    public void BuildSecondChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "Church1")
        {
            PlayStatManager.instance.Briket -= 250;
            KingAbilityManager.instance.AdministrativePower -= 600;
            PlayStatManager.instance.Food -= 3;

            Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
            Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
            Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);
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
            PlayStatManager.instance.Briket -= 500;
            KingAbilityManager.instance.AdministrativePower -= 800;
            PlayStatManager.instance.Food -= 5;

            Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
            Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
            Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);
            SecondChurch.SetActive(false);
            ThirdChurch.SetActive(true);
            Debug.Log("3단계 교회 생성");
        }
    }
}