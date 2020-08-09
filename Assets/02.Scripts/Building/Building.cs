using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private Rigidbody buildingRigidbody;


    //빌딩종류: Town, Farm, Harbor, Court, Market, Guild, Church, Castle, FoodWarehouse 
    public enum BuildingType { Building, Harbor, Church, FoodWarehouse }
    //법원
    BuildingType buildingType = BuildingType.Building;

    void Start()
    {
        //게임 오브젝트에서 RIgidbody컴포넌트를 찾아 buildingRigidbody에 할당
        buildingRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
    }

    
}

