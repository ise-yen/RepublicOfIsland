using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchBuilt : MonoBehaviour
{
    public static ChurchBuilt instance;
    public enum ChurchStage { zero, one, two, three }
    public ChurchStage buildingChurchStage = ChurchStage.zero;
    public GameObject[] churchMesh;

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
    public void LoadCourtUI()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj != null)
        {
            if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.zero])
            {
                UIManager.instance.SpawnBuildingPage(Building.Church, (int)ChurchStage.zero);
            }
            if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.one])
            {
                UIManager.instance.SpawnBuildingPage(Building.Church, (int)ChurchStage.one);
            }
            if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.two])
            {
                UIManager.instance.SpawnBuildingPage(Building.Church, (int)ChurchStage.two);
            }
        }
    }

    public void UpgradeChurch()
    {
        UsingStatForChurch();
        BuildNextChurch();
    }

    public void UsingStatForChurch()
    {
        /*
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj != null)
        {
            if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.zero])
         */
        if (buildingChurchStage == ChurchStage.zero)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -125);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -400);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
        }
        if (buildingChurchStage == ChurchStage.one)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -250);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
        }
        if (buildingChurchStage == ChurchStage.two)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -500);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -800);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -5);
        }
    }

    public void BuildNextChurch()
    {
        if((int)buildingChurchStage < 3)
        {
            churchMesh[(int)buildingChurchStage].SetActive(false);
            buildingChurchStage = buildingChurchStage + 1;
            churchMesh[(int)buildingChurchStage].SetActive(true);
        }
    }
}