using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtBuilt : MonoBehaviour
{
    public static CourtBuilt instance;
    public enum CourtStage { zero, one, two, three }
    public CourtStage buildingCourtStage = CourtStage.zero;
    public GameObject[] courtMesh;

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

    public void UpgradeCourt()
    {
        UsingStatForCourt();
        BuildNextCourt();
    }

    public void CheckBuilding()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj != null)
        {
            if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.zero])
            {
                UIManager.instance.SpawnBuildingPage(Building.Court, (int)CourtStage.zero);
            }
            if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.one])
            {
                UIManager.instance.SpawnBuildingPage(Building.Court, (int)CourtStage.one);
            }
            if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.two])
            {
                UIManager.instance.SpawnBuildingPage(Building.Court, (int)CourtStage.two);
            }
        }

    }
    public void UsingStatForCourt()
    {
        /*     
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj != null)
        {
            if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.zero])
         */
        if (buildingCourtStage == CourtStage.zero)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -100);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -250);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
        }
        if (buildingCourtStage == CourtStage.one)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -200);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -450);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -2);
            }
        if (buildingCourtStage == CourtStage.two)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -300);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
        }
    }

    public void BuildNextCourt()
    {
        if ((int)buildingCourtStage < 3)
        {
            courtMesh[(int)buildingCourtStage].SetActive(false);
            buildingCourtStage = buildingCourtStage + 1;
            courtMesh[(int)buildingCourtStage].SetActive(true);
        }
    }
}