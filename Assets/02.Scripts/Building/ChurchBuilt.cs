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
            RayHitting.instance.ClickObject();
            if (RayHitting.instance.SelectObj != null)
            {
                Debug.Log("target: " + RayHitting.instance.SelectObj.name);
                if (RayHitting.instance.SelectObj.name == "ChurchPlane")
                {
                    RayHitting.instance.SelectObj.SetActive(false);
                    Debug.Log("0단계 눌렀습니다.");
                    BuildFirstChurch();
                }
                if (RayHitting.instance.SelectObj.name == "Church1")
                {
                    Debug.Log("1단계 눌렀습니다.");
                    BuildSecondChurch();
                }
                if (RayHitting.instance.SelectObj.name == "Church2")
                {
                    Debug.Log("2단계 눌렀습니다.");
                    BuildThirdChurch();
                }
            }
            Debug.Log("교회 생성 완료");
        }
    }

    public void BuildFirstChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Briket, -125);
        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        PlayerSystemManager.instance.ObtainKingAbility(PlayerSystemManager.KingAbility.AdministrativePower, -400);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Food, -1);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstChurch.SetActive(true);
        Debug.Log("1단계 교회 생성");
    }
    public void BuildSecondChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Briket, -250);
        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        PlayerSystemManager.instance.ObtainKingAbility(PlayerSystemManager.KingAbility.AdministrativePower, -600);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Food, -3);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstChurch.SetActive(false);
        SecondChurch.SetActive(true);
        Debug.Log("2단계 교회 생성");
    }
    public void BuildThirdChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Briket, -500);
        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        PlayerSystemManager.instance.ObtainKingAbility(PlayerSystemManager.KingAbility.AdministrativePower, -800);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Food, -5);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        SecondChurch.SetActive(false);
        ThirdChurch.SetActive(true);
        Debug.Log("3단계 교회 생성");
    }
}