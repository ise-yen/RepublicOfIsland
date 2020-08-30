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

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -400);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);

        FirstChurch.SetActive(true);
    }
    public void BuildSecondChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -250);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);

        FirstChurch.SetActive(false);
        SecondChurch.SetActive(true);
    }
    public void BuildThirdChurch()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -500);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -800);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -5);

        SecondChurch.SetActive(false);
        ThirdChurch.SetActive(true);
    }
}