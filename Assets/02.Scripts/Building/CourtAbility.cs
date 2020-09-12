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
    }
    void SecondCourtAblity()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Crime, -5);
    }
    void ThirdCourtAblity()
    {
        PlayerSystemManager.instance.StatingStat(PlayState.Crime, -10);
    }
}
