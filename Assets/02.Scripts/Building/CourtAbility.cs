using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtAbility : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (RayHitting.instance.SelectObj.name == "court1")
            {
                FirstCourtAblity();
            }
            if (RayHitting.instance.SelectObj.name == "court2")
            {
                SecondCourtAblity();
            }
            if (RayHitting.instance.SelectObj.name == "court3")
            {
                ThirdCourtAblity();
            }
        }
    }

    void FirstCourtAblity()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Crime, -2);
        Debug.Log("<1단계 법원 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
    }
    void SecondCourtAblity()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Crime, -5);
        Debug.Log("<2단계 법원 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
    }
    void ThirdCourtAblity()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Crime, -10);
        Debug.Log("<3단계 법원 능력>");
        Debug.Log("범죄율: " + PlayStatManager.instance.CrimeRate);
    }
}
