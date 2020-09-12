using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingBuilt : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            ChurchBuilt.instance.UpgradeChurch();
            CourtBuilt.instance.UpgradeCourt();
        }
    }
}
