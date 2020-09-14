using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Court : Building
{
    private void Start()
    {
        InitBuilding();
    }
    protected override void InitBuilding()
    {
        base.InitBuilding();
        buildingType = BuildingType.Court;
    }

    public override void UsingStat()
    {
        /*     
       RayHitting.instance.ClickObject();
       if (RayHitting.instance.SelectObj != null)
       {
           if (RayHitting.instance.SelectObj == courtMesh[(int)CourtStage.zero])
        */
        if (level == 0)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -100);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -250);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
        }
        if (level == 1)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -200);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -450);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -2);
        }
        if (level == 2)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -300);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
        }
    }
}
