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
                if (RayHitting.instance.SelectObj.name == "churchPlane")
                {
                    RayHitting.instance.SelectObj.SetActive(false);
                    BuildFirstChurch();
                }
                if (RayHitting.instance.SelectObj.name == "church1")
                {
                    BuildSecondChurch();
                }
                if (RayHitting.instance.SelectObj.name == "church2")
                {
                    BuildThirdChurch();
                }
            }
        }
    }

    public void BuildFirstChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -125);
        //Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -400);
        //Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
        //Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstChurch.SetActive(true);
    }
    public void BuildSecondChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -250);
        //Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
        //Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
        //Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstChurch.SetActive(false);
        SecondChurch.SetActive(true);
    }
    public void BuildThirdChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -500);
        //Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -800);
        //Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -5);
        //Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        SecondChurch.SetActive(false);
        ThirdChurch.SetActive(true);
    }
}