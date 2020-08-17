using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslamAbility : MonoBehaviour
{
    //지속효과
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
