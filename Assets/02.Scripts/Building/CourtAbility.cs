using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtAbility : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.name == "Court1")
            {
                FirstCourtAblity();
            }
            if (gameObject.name == "Court2")
            {
                SecondCourtAblity();
            }
            if (gameObject.name == "Court3")
            {
                ThirdCourtAblity();
            }
        }
    }

    void FirstCourtAblity()
    {
        PlayStatManager.instance.CrimeRate -= 2;
        Debug.Log("<1단계 법원 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }
    void SecondCourtAblity()
    {
        PlayStatManager.instance.CrimeRate -= 5;
        //KingAbilityManager.instance.WarPower += 100;
        Debug.Log("<2단계 법원 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }
    void ThirdCourtAblity()
    {
        PlayStatManager.instance.CrimeRate -= 10;
        //KingAbilityManager.instance.WarPower += 200;
        Debug.Log("<3단계 법원 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
        //Debug.Log("군대: " + KingAbilityManager.instance.WarPower);
    }
}
