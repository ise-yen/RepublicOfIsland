using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtBuilt : MonoBehaviour
{
    //건설에 사용되는 재화 종류: 세금(브리킷) of PlayStatManager, 행정력 of KingAbilityManager, 식량 of PlayStatManager

    //건물을 담을 오브젝트
    public GameObject FirstCourt;
    public GameObject SecondCourt;
    public GameObject ThirdCourt;

    public enum CourtState { Zerocourt, Firstcourt, Secondcourt, Thirdcourt }

    CourtState courtState = CourtState.Zerocourt;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (RayHitting.instance.SelectObj.name == "CourtPlane")
            {
                BuildFirstCourt();
            }
            else if (RayHitting.instance.SelectObj.name == "Court1")
            {
                BuildSecondCourt();
            }
            else if (RayHitting.instance.SelectObj.name == "Court2")
            {
                BuildThirdCourt();
            }
        }
    }
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

    public void BuildFirstCourt()
    {
        RayHitting.instance.ClickObject();
        PlayStatManager.instance.Briket -= 100;
        KingAbilityManager.instance.AdministrativePower -= 250;
        PlayStatManager.instance.Food -= 1;

        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);
        FirstCourt.SetActive(true);
        Debug.Log("1단계 법원 생성");
    }
    public void BuildSecondCourt()
    {
        RayHitting.instance.ClickObject();
        PlayStatManager.instance.Briket -= 200;
        KingAbilityManager.instance.AdministrativePower -= 450;
        PlayStatManager.instance.Food -= 2;

        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);
        FirstCourt.SetActive(false);
        SecondCourt.SetActive(true);
        Debug.Log("2단계 법원 생성");
    }
    public void BuildThirdCourt()
    {
        RayHitting.instance.ClickObject();
        PlayStatManager.instance.Briket -= 300;
        KingAbilityManager.instance.AdministrativePower -= 600;
        PlayStatManager.instance.Food -= 3;

        Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
        Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
        Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);
        SecondCourt.SetActive(false);
        ThirdCourt.SetActive(true);
        Debug.Log("3단계 법원 생성");
    }
}