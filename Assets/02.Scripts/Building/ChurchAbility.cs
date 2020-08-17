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

}
