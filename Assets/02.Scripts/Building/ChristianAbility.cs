using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChristianAbility : MonoBehaviour
{    
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
}
