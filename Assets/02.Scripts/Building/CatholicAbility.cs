using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatholicAbility : MonoBehaviour
{
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
}
