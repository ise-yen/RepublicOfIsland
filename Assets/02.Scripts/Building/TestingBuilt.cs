using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingBuilt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            ChurchBuilt.instance.BuildNextChurch();
            ChurchBuilt.instance.UpgradeChurch();

            CourtBuilt.instance.BuildNextCourt();
            CourtBuilt.instance.UpgradeCourt();
        }
    }
}
