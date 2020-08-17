using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchAbility : MonoBehaviour
{
    void Update()
    {


        if (ReligionManager.instance.religionState == ReligionManager.Religion.Catholic)
        {
            if (RayHitting.instance.SelectObj.name == "CourtPlane")
            {
                FirstCatholicPassive();
                FirstCatholicActive();
            }
            else if (RayHitting.instance.SelectObj.name == "Court1")
            {
                SecondCatholicPassive();
                SecondCatholicActive();
            }
            else if (RayHitting.instance.SelectObj.name == "Court2")
            {
                ThirdCatholicPassive();
                ThirdCatholicActive();
            }
        }
        else if (ReligionManager.instance.religionState == ReligionManager.Religion.Christian)
        {
            if (RayHitting.instance.SelectObj.name == "CourtPlane")
            {
                FirstChristianPassive();
                FirstChristianActive();
            }
            else if (RayHitting.instance.SelectObj.name == "Court1")
            {
                SecondChristianPassive();
                SecondChristianActive();
            }
            else if (RayHitting.instance.SelectObj.name == "Court2")
            {
                ThirdChristianPassive();
                ThirdChristianActive();
            }
        }
        else if (ReligionManager.instance.religionState == ReligionManager.Religion.Islam)
        {
            if (RayHitting.instance.SelectObj.name == "CourtPlane")
            {
                FirstIslamPassive();
                FirstIslamActive();
            }
            else if (RayHitting.instance.SelectObj.name == "Court1")
            {
                SecondIslamPassive();
                SecondIslamActive();
            }
            else if (RayHitting.instance.SelectObj.name == "Court2")
            {
                ThirdIslamPassive();
                ThirdIslamActive();
            }
        }
    }
    //가톨릭 효과
    //지속효과
    void FirstCatholicPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 1;
        Debug.Log("<1단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }
    void SecondCatholicPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 3;
        //지속효과2 //KingAbilityManager.instance.WarPower += 100;
        Debug.Log("<2단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }

    void ThirdCatholicPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 5;
        //지속효과2 //KingAbilityManager.instance.WarPower += 300;
        Debug.Log("<3단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }

    //액티브효과
    void FirstCatholicActive()
    {
        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);
        KingAbilityManager.instance.AdministrativePower -= 200;

        //액티브효과2
        PlayStatManager.instance.Briket += 50;
        Debug.Log("브리킷: " + PlayStatManager.instance.Briket);
        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과3
        ReligionManager.instance.MainReligion += 1;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void SecondCatholicActive()
    {
        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);
        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2
        PlayStatManager.instance.Briket += 75;
        Debug.Log("브리킷: " + PlayStatManager.instance.Briket);
        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과3
        ReligionManager.instance.MainReligion += 2;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void ThirdCatholicActive()
    {
        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);
        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과2
        PlayStatManager.instance.Briket += 100;
        Debug.Log("브리킷: " + PlayStatManager.instance.Briket);
        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과3
        ReligionManager.instance.MainReligion += 3;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }


    //기독교 효과
    //지속효과
    void FirstChristianPassive()
    {
        //지속효과1
        PlayStatManager.instance.CrimeRate -= 2;
        Debug.Log("<1단계 교회 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
    }
    void SecondChristianPassive()
    {
        //지속효과1
        PlayStatManager.instance.CrimeRate -= 3;
        //지속효과2
        PlayStatManager.instance.ComfortRate += 1;
        Debug.Log("<2단계 교회 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);
    }

    void ThirdChristianPassive()
    {
        //지속효과1
        PlayStatManager.instance.CrimeRate -= 5;
        //지속효과2
        PlayStatManager.instance.ComfortRate += 3;
        Debug.Log("<3단계 교회 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);
    }

    //액티브효과
    void FirstChristianActive()
    {
        //액티브효과1
        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 1;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void SecondChristianActive()
    {
        //액티브효과1
        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 2;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void ThirdChristianActive()
    {
        //액티브효과1
        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 3;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }

    //이슬람 효과
    void FirstIslamPassive()
    {
        //지속효과1
        PlayStatManager.instance.Food += 3;
        Debug.Log("<1단계 교회 능력>");
        Debug.Log("식량: " + PlayStatManager.instance.Food);
    }
    void SecondIslamPassive()
    {
        //지속효과1
        PlayStatManager.instance.Food += 5;
        Debug.Log("<2단계 교회 능력>");
        Debug.Log("식량: " + PlayStatManager.instance.Food);
    }

    void ThirdIslamPassive()
    {
        //지속효과1
        PlayStatManager.instance.Food += 7;
        Debug.Log("<3단계 교회 능력>");
        Debug.Log("식량: " + PlayStatManager.instance.Food);
    }

    //액티브효과
    void FirstIslamActive()
    {
        //액티브효과1
        PlayStatManager.instance.TradeRate += 1;
        Debug.Log("무역력: " + PlayStatManager.instance.TradeRate);
        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 1;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void SecondIslamActive()
    {
        //액티브효과1
        PlayStatManager.instance.TradeRate += 3;
        Debug.Log("무역력: " + PlayStatManager.instance.TradeRate);
        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 2;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void ThirdIslamActive()
    {
        //액티브효과1
        PlayStatManager.instance.TradeRate += 5;
        Debug.Log("무역력: " + PlayStatManager.instance.TradeRate);
        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 3;
        Debug.Log("종교 지지도: " + ReligionManager.instance.MainReligion);
        KingAbilityManager.instance.AdministrativePower -= 50;
    }
}
