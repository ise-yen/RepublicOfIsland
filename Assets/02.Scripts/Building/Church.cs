using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Church : Building
{
    private void Start()
    {
        InitBuilding();
    }
    protected override void InitBuilding()
    {
        base.InitBuilding();
        buildingType = BuildingType.Church;
    }

    public override void UsingStat()
    {
        /*
                RayHitting.instance.ClickObject();
                if (RayHitting.instance.SelectObj != null)
                {
                    if (RayHitting.instance.SelectObj == churchMesh[(int)ChurchStage.zero])
                 */
        if (level == 0)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -125);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -400);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
        }
        if (level == 1)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -250);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
        }
        if (level == 2)
        {
            PlayerSystemManager.instance.StatingStat(PlayState.Briket, -500);
            PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -800);
            PlayerSystemManager.instance.StatingStat(PlayState.Food, -5);
        }
    }
}
