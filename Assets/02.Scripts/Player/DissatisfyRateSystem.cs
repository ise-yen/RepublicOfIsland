using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissatisfyRateSystem : MonoBehaviour
{
    //불만도 시스템
    public int dissatisfactionSystem = 2;
    StabilitySystem stability;
    void Start()
    {
        stability = other.GetComponent<StabilitySystem>();
    }

    void Update()
    {
        if(dissatisfactionSystem < 0)
        {
            stability = stability - 1;
        }
    }


}
