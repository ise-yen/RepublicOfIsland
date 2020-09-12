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

    public void UpgradeChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj != null)
        {
            // if (RayHitting.instance.SelectObj.name == "churchPlane")
            if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.zero])
            {
                PlayerSystemManager.instance.StatingStat(PlayState.Briket, -125);
                PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -400);
                PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
                BuildNextChurch();
            }
            if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.one])
            {
                PlayerSystemManager.instance.StatingStat(PlayState.Briket, -250);
                PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
                PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
                BuildNextChurch();
            }
            if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.two])
            {
                PlayerSystemManager.instance.StatingStat(PlayState.Briket, -500);
                PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -800);
                PlayerSystemManager.instance.StatingStat(PlayState.Food, -5);
                BuildNextChurch();
            }
        }
    }

    public void BuildNextChurch()
    {
        churchMesh[(int)buildingChurchStage].SetActive(false);
        buildingChurchStage = buildingChurchStage + 1;
        churchMesh[(int)buildingChurchStage].SetActive(true);
    }
}