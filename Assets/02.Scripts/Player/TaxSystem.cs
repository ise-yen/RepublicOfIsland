using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxSystem : MonoBehaviour
{
    //세금(=브리킷) 시스템
    void Start()
    {
    }

    void Update()
    {
        
    }

    void PeriodicTax()
    {
        //라운드당 +3씩 증가
        PlayStatManager.instance.Tax += 3;
    }
}
