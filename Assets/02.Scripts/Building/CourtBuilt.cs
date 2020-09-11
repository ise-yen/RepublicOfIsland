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

    private void Update()
    {
        ChurchBuilt.instance.UpgradeChurch();
    }
    public void UpgradeCourt()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj != null)
        {
            // if (RayHitting.instance.SelectObj.name == "courtPlane")
            if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.zero])
            {
                PlayerSystemManager.instance.StatingStat(PlayState.Briket, -100);
                PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -250);
                PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
                BuildNextCourt();
            }
            if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.one])
            {
                PlayerSystemManager.instance.StatingStat(PlayState.Briket, -200);
                PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -450);
                PlayerSystemManager.instance.StatingStat(PlayState.Food, -2);
                BuildNextCourt();
            }
            if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.two])
            {
                PlayerSystemManager.instance.StatingStat(PlayState.Briket, -300);
                PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
                PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
                BuildNextCourt();
            }
        }
    }

    public void BuildNextCourt()
    {
        courtMesh[(int)buildingCourtStage].SetActive(false);
        buildingCourtStage = buildingCourtStage + 1;
        courtMesh[(int)buildingCourtStage].SetActive(true);
    }
}
