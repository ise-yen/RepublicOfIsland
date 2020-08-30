using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtBuilt : MonoBehaviour
{
    //건물을 담을 오브젝트
    public GameObject FirstCourt;
    public GameObject SecondCourt;
    public GameObject ThirdCourt;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayHitting.instance.ClickObject();
            if(RayHitting.instance.SelectObj != null)
            {
                if (RayHitting.instance.SelectObj.name == "courtPlane")
                {
                    RayHitting.instance.SelectObj.SetActive(false);
                    BuildFirstCourt();
                }
                if (RayHitting.instance.SelectObj.name == "court1")
                {
                    BuildSecondCourt();
                }
                if (RayHitting.instance.SelectObj.name == "court2")
                {
                    BuildThirdCourt();
                }
            }
        }

    }
    public void BuildFirstCourt()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -100);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -250);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);

        FirstCourt.SetActive(true);
    }
    public void BuildSecondCourt()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -200);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -450);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -2);

        FirstCourt.SetActive(false);
        SecondCourt.SetActive(true);
    }
    public void BuildThirdCourt()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -300);

        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);

        PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);

        SecondCourt.SetActive(false);
        ThirdCourt.SetActive(true);
    }
}
