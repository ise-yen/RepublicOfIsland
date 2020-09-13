using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingBuilt : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            ChurchBuilt.instance.UpgradeChurch();
        }
        if (Input.GetKeyDown(KeyCode.Keypad1)){
            CourtBuilt.instance.UpgradeCourt();
        }
    }
}
