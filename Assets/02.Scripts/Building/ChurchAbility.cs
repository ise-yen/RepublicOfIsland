using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchAbility : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.name == "Church1")
            {
                FirstChurchPassive();
            }
            if (gameObject.name == "Church2")
            {
                SecondChurchPassive();
            }
            if (gameObject.name == "Church3")
            {
                ThirdChurchPassive();
            }
        }
    }

    //교회 단계별 지속 효과
    void FirstChurchPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 1;
        Debug.Log("<1단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);

        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        KingAbilityManager.instance.AdministrativePower -= 200;
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);

        //액티브효과2
        PlayStatManager.instance.Briket += 50;
        Debug.Log("브리킷: " + PlayStatManager.instance.Briket);

        //액티브효과3
    }
    void SecondChurchPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 3;
        //지속효과2 //KingAbilityManager.instance.WarPower += 100;
        Debug.Log("<2단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);

        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        KingAbilityManager.instance.AdministrativePower -= 150;
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);

        //액티브효과2
        PlayStatManager.instance.Briket += 75;
        Debug.Log("브리킷: " + PlayStatManager.instance.Briket);

        //액티브효과3
    }

    void ThirdChurchPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 5;
        //지속효과2 //KingAbilityManager.instance.WarPower += 300;
        Debug.Log("<3단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);

        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        KingAbilityManager.instance.AdministrativePower -= 100;
        Debug.Log("안정도: " + PlayStatManager.instance.ComfortRate);

        //액티브효과2
        PlayStatManager.instance.Briket += 100;
        Debug.Log("브리킷: " + PlayStatManager.instance.Briket);

        //액티브효과3
    }
}
