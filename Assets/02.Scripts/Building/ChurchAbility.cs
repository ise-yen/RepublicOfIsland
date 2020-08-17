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
        PlayStatManager.instance.Tax += 1;
        Debug.Log("<1단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }
    void SecondChurchPassive()
    {
        PlayStatManager.instance.Tax += 3;
        //KingAbilityManager.instance.WarPower += 100;
        Debug.Log("<2단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }

    void ThirdChurchPassive()
    {
        PlayStatManager.instance.Tax += 5;
        //KingAbilityManager.instance.WarPower += 300;
        Debug.Log("<3단계 교회 능력>");
        Debug.Log("세금: " + PlayStatManager.instance.Tax);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }
}
