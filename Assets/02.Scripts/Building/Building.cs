using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public BuildingType buildingType;

    protected int level = 0;
    
    public Transform[] buildingMesh;

    protected virtual void InitBuilding()
    {
        buildingMesh = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            buildingMesh[i] = transform.GetChild(i);
        }
        //buildingMesh = GetComponentsInChildren<Transform>();
    }

    public void LevelUpBuilding()
    {
        if (level == 2)
            return;

        UsingStat();

        buildingMesh[level].gameObject.SetActive(false);
        level++;
        buildingMesh[level].gameObject.SetActive(true);
    }

    public virtual void UsingStat()
    {
        
    }

    public void SpawnEventPage()
    {
        if (level == 2)
            return;
        UIManager.instance.SpawnBuildingPage(buildingType, level);
    }
}
