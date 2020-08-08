using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtAbility : MonoBehaviour
{
    int crimeRate;
    int military;
    //int timeCheck = 1;

    void Start()
    {
        crimeRate = 20;
        military = 0;
    }
    void Update()
    {
        //TimeCount.instance.TimeUp();
        //if(timeCheck == TimeCount.instance.count)
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

        //timeCheck++;
    }

    void FirstCourtAblity()
    {
        crimeRate = crimeRate - 2;
        Debug.Log("<1단계 법원 능력>");
        Debug.Log("범죄율: " + crimeRate);
        Debug.Log("군대: " + military);
    }
    void SecondCourtAblity()
    {
        crimeRate = crimeRate - 5;
        military = military + 100;
        Debug.Log("<2단계 법원 능력>");
        Debug.Log("범죄율: " + crimeRate);
        Debug.Log("군대: " + military);
    }
    void ThirdCourtAblity()
    {
        crimeRate = crimeRate - 10;
        military = military + 200;
        Debug.Log("<3단계 법원 능력>");
        Debug.Log("범죄율: " + crimeRate);
        Debug.Log("군대: " + military);
    }
}
