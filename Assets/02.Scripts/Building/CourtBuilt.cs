using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtBuilt : MonoBehaviour
{
    //GameObject target;
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
                Debug.Log("target: " + RayHitting.instance.SelectObj.name);
                if (RayHitting.instance.SelectObj.name == "courtPlane")
                {
                    RayHitting.instance.SelectObj.SetActive(false);
                    Debug.Log("0단계 눌렀습니다.");
                    BuildFirstCourt();
                }
                if (RayHitting.instance.SelectObj.name == "court1")
                {
                    Debug.Log("1단계 눌렀습니다.");
                    BuildSecondCourt();
                }
                if (RayHitting.instance.SelectObj.name == "court2")
                {
                    Debug.Log("2단계 눌렀습니다.");
                    BuildThirdCourt();
                }
            }
        }

    }
    public void BuildFirstCourt()
    {
        //RayHitting.instance.ClickObject();
        //RayHitting.instance.Target = RayHitting.instance.GetClickedObject();

        //PlayStatManager.instance.Briket -= 100;
        Debug.Log("브리킷: "+ PlayStatManager.instance.Briket);
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -100);
        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        Debug.Log("행정력: " + KingAbilityManager.instance.AdministrativePower);
        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -250);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        Debug.Log("식량: " + PlayStatManager.instance.Food);
        PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstCourt.SetActive(true);
        Debug.Log("1단계 법원 생성");
    }
    public void BuildSecondCourt()
    {
        //RayHitting.instance.ClickObject();
        //RayHitting.instance.Target = RayHitting.instance.GetClickedObject();

        Debug.Log("브리킷: "+ PlayStatManager.instance.Briket);
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -200);
        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
      
        Debug.Log("행정력: " + KingAbilityManager.instance.AdministrativePower);
        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -450);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        Debug.Log("식량: " + PlayStatManager.instance.Food);
        PlayerSystemManager.instance.StatingStat(PlayState.Food, -2);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstCourt.SetActive(false);
        SecondCourt.SetActive(true);
        Debug.Log("2단계 법원 생성");
    }
    public void BuildThirdCourt()
    {
        //RayHitting.instance.ClickObject();
        //RayHitting.instance.Target = RayHitting.instance.GetClickedObject();

        Debug.Log("브리킷: "+ PlayStatManager.instance.Briket);
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -300);
        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
       
        Debug.Log("행정력: " + KingAbilityManager.instance.AdministrativePower);
        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
     
        Debug.Log("식량: " + PlayStatManager.instance.Food);
        PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        SecondCourt.SetActive(false);
        ThirdCourt.SetActive(true);
        Debug.Log("3단계 법원 생성");
    }
}


    //public enum CourtState { Zerocourt, Firstcourt, Secondcourt, Thirdcourt }
    //CourtState courtState = CourtState.Zerocourt;
    /*
    if (Input.GetMouseButtonDown(0))
    {
        Debug.Log("눌렀습니다.");
        if (RayHitting.instance.SelectObj.name == "CourtPlane")
        {
            Debug.Log("1단계 눌렀습니다.");
            BuildFirstCourt();
        }
        else if (RayHitting.instance.SelectObj.name == "Court1")
        {
            Debug.Log("2단계 눌렀습니다.");
            BuildSecondCourt();
        }
        else if (RayHitting.instance.SelectObj.name == "Court2")
        {
            Debug.Log("3단계 눌렀습니다.");
            BuildThirdCourt();
        }
        else
        {
            Debug.Log("잘못 눌렀습니다.");
        }
    }
    */

/*
CourtState UpgradeCourt(CourtState _court)
{
    if(_court == CourtState.Zerocourt)
    {
        _court = CourtState.Firstcourt;
    }
    else if(_court == CourtState.Firstcourt)
    {
        _court = CourtState.Secondcourt;
    }
    else if (_court == CourtState.Secondcourt)
    {
        _court = CourtState.Thirdcourt;
    }
    return _court;
}
*/
