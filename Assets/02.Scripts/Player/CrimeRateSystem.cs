using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CrimeRateSystem : MonoBehaviour
{
    //범죄율 시스템
    public int crimeRate = 2; //범죄율(%)
    private StabilitySystem stabilitySystem;

    void Start()
    {
        Debug.Log("현재 범죄율 : " + crimeRate + "%");

        stabilitySystem = GameObject.Find("Crime").GetComponent<StabilitySystem>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            crimeRate = ObtainCrimeRate();
            ConfirmCrimeRate();
            EventingCrimeRate();
        }
    }

    void ConfirmCrimeRate()
    {
        Debug.Log("현재 범죄율 : " + crimeRate + "%");
    }

    int ObtainCrimeRate()
    {
        Debug.Log("범죄율 증가");
        crimeRate = crimeRate + Mathf.Abs(stabilitySystem.stability);
        return crimeRate;
    }
    void EventingCrimeRate()
    {
        if (crimeRate <= 100 && crimeRate > 0)
        {
            //10%~20%미만
            if (crimeRate % 10 == 0)
            {
                Debug.Log("<범죄율 " + crimeRate + "% 특정 이벤트 발생>");
            }
        }
        if (crimeRate == 0)
        {
            Debug.Log("<범죄율 0% 특정 이벤트 발생>");
        }
    }

}
