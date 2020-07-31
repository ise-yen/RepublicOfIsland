using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    int administrativePower = 2; //행정력
    int economicPower = 2; //경제력
    int warMachine = 2; //군사력

    void Start()
    {
        Debug.Log("[행정력/경제력/군사력] : " + administrativePower + "/" + economicPower + "/" + warMachine);
    }

    void Update()
    {
        ObtainAbilitiy();
    }

    void ObtainAbilitiy()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            administrativePower++;
            Debug.Log("[행정력/경제력/군사력] : " + administrativePower + "/" + economicPower + "/" + warMachine);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            economicPower++;
            Debug.Log("[행정력/경제력/군사력] : " + administrativePower + "/" + economicPower + "/" + warMachine);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            warMachine++;
            Debug.Log("[행정력/경제력/군사력] : " + administrativePower + "/" + economicPower + "/" + warMachine);
        }
    }
}
