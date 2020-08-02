using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public static Building instance;
    public enum BuildingType { Town, Farm, Harbor, Court, Market, Guild, Church, Castle, FoodWarehouse }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }

    public void BuildBuilding()
    {

    }

    public void Court()
    {
        //재화 money, 브리킷 brikit, 행정력, 식량 food
    }

    public void Church()
    {

    }
}
