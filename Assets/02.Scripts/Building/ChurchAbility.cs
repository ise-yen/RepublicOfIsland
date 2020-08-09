using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchAbility : MonoBehaviour
{
    int crimeRates;
    int militarys;
    int tax;
    int stabilitys;
    int brekits;
    int religionship;

    void Start()
    {
        crimeRates = 20;
        militarys = 0;
        tax = 0;
    }

    // Update is called once per frame
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
        tax = tax + 1;
        Debug.Log("<1단계 교회 능력>");
        Debug.Log("세금: " + tax);
        Debug.Log("군대: " + militarys);
    }
    void SecondChurchPassive()
    {
        tax = tax + 3;
        militarys = militarys + 100;
        Debug.Log("<2단계 교회 능력>");
        Debug.Log("세금: " + tax);
        Debug.Log("군대: " + militarys);
    }

    void ThirdChurchPassive()
    {
        tax = tax + 5;
        militarys = militarys + 300;
        Debug.Log("<3단계 교회 능력>");
        Debug.Log("세금: " + tax);
        Debug.Log("군대: " + militarys);
    }
}
