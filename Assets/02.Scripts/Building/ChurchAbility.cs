using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchAbility : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ReligionManager.instance.religionState == ReligionManager.Religion.Catholic)
            {
                if (RayHitting.instance.SelectObj.name == "church1")
                {
                    FirstCatholicPassive();
                    FirstCatholicActive();
                }
                else if (RayHitting.instance.SelectObj.name == "church2")
                {
                    SecondCatholicPassive();
                    SecondCatholicActive();
                }
                else if (RayHitting.instance.SelectObj.name == "church3")
                {
                    ThirdCatholicPassive();
                    ThirdCatholicActive();
                }
            }
            else if (ReligionManager.instance.religionState == ReligionManager.Religion.Christian)
            {
                if (RayHitting.instance.SelectObj.name == "church1")
                {
                    FirstChristianPassive();
                    FirstChristianActive();
                }
                else if (RayHitting.instance.SelectObj.name == "church2")
                {
                    SecondChristianPassive();
                    SecondChristianActive();
                }
                else if (RayHitting.instance.SelectObj.name == "church3")
                {
                    ThirdChristianPassive();
                    ThirdChristianActive();
                }
            }
            else if (ReligionManager.instance.religionState == ReligionManager.Religion.Islam)
            {
                if (RayHitting.instance.SelectObj.name == "church1")
                {
                    FirstIslamPassive();
                    FirstIslamActive();
                }
                else if (RayHitting.instance.SelectObj.name == "church2")
                {
                    SecondIslamPassive();
                    SecondIslamActive();
                }
                else if (RayHitting.instance.SelectObj.name == "church3")
                {
                    ThirdIslamPassive();
                    ThirdIslamActive();
                }
            }
        }
    }
    //가톨릭 효과
    //지속효과
    void FirstCatholicPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 1;
    }
    void SecondCatholicPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 3;
    }

    void ThirdCatholicPassive()
    {
        //지속효과1
        PlayStatManager.instance.Tax += 5;
    }

    //액티브효과
    void FirstCatholicActive()
    {
        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);

        KingAbilityManager.instance.AdministrativePower -= 200;

        //액티브효과2
        PlayStatManager.instance.Briket += 50;

        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과3
        ReligionManager.instance.MainReligion += 1;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void SecondCatholicActive()
    {
        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);

        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2
        PlayStatManager.instance.Briket += 75;

        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과3
        ReligionManager.instance.MainReligion += 2;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void ThirdCatholicActive()
    {
        //액티브효과1
        PlayStatManager.instance.ComfortRate += 1;
        UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);

        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과2
        PlayStatManager.instance.Briket += 100;

        KingAbilityManager.instance.AdministrativePower -= 100;

        //액티브효과3
        ReligionManager.instance.MainReligion += 3;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }


    //기독교 효과
    //지속효과
    void FirstChristianPassive()
    {
        //지속효과1
        PlayStatManager.instance.CrimeRate -= 2;
        UIManager.instance.SetPlayerStat(PlayState.Crime, PlayStatManager.instance.CrimeRate);
    }
    void SecondChristianPassive()
    {
        //지속효과1
        PlayStatManager.instance.CrimeRate -= 3;
        UIManager.instance.SetPlayerStat(PlayState.Crime, PlayStatManager.instance.CrimeRate);
        //지속효과2
        PlayStatManager.instance.ComfortRate += 1;
        UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);
    }

    void ThirdChristianPassive()
    {
        //지속효과1
        PlayStatManager.instance.CrimeRate -= 5;
        UIManager.instance.SetPlayerStat(PlayState.Crime, PlayStatManager.instance.CrimeRate);
        //지속효과2
        PlayStatManager.instance.ComfortRate += 3;
        UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);
    }

    //액티브효과
    void FirstChristianActive()
    {
        //액티브효과1
        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 1;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void SecondChristianActive()
    {
        //액티브효과1
        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 2;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void ThirdChristianActive()
    {
        //액티브효과1
        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 3;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }

    //이슬람 효과
    void FirstIslamPassive()
    {
        //지속효과1
        PlayStatManager.instance.Food += 3;
    }
    void SecondIslamPassive()
    {
        //지속효과1
        PlayStatManager.instance.Food += 5;
    }

    void ThirdIslamPassive()
    {
        //지속효과1
        PlayStatManager.instance.Food += 7;
    }

    //액티브효과
    void FirstIslamActive()
    {
        //액티브효과1
        PlayStatManager.instance.TradeRate += 1;
        UIManager.instance.SetPlayerStat(PlayState.Trade, PlayStatManager.instance.TradeRate);

        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 1;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void SecondIslamActive()
    {
        //액티브효과1
        PlayStatManager.instance.TradeRate += 3;
        UIManager.instance.SetPlayerStat(PlayState.Trade, PlayStatManager.instance.TradeRate);

        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 2;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }
    void ThirdIslamActive()
    {
        //액티브효과1
        PlayStatManager.instance.TradeRate += 5;
        UIManager.instance.SetPlayerStat(PlayState.Trade, PlayStatManager.instance.TradeRate);

        KingAbilityManager.instance.AdministrativePower -= 150;

        //액티브효과2

        //액티브효과3
        ReligionManager.instance.MainReligion += 3;

        KingAbilityManager.instance.AdministrativePower -= 50;
    }
}
