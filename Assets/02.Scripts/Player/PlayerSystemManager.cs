using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSystemManager : MonoBehaviour
{
    public static PlayerSystemManager instance;
    //KingAbilityManager: 행정력, 경제력, 군사력

    //PlayStatManager: 브리킷, 세금, 불만도, 안정도, 범죄율, 무역력, 식량
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
    public void ObtainKingAbility(KingAbility kingAbility, int add)
    {
        if (kingAbility == KingAbility.AdministrativePower)
        {
            KingAbilityManager.instance.AdministrativePower += add;
        }
        else if (kingAbility == KingAbility.EconomicPower)
        {
            KingAbilityManager.instance.EconomicPower += add;
        }
        else if (kingAbility == KingAbility.WarPower)
        {
            KingAbilityManager.instance.WarPower += add;
        }
    }

    public void StatingStat(PlayState playState, int add)
    {
        if (playState == PlayState.Briket)
        {
            PlayStatManager.instance.Briket += add;
        }
        else if (playState == PlayState.Tax)
        {
            PlayStatManager.instance.Tax += add;
        }
        else if (playState == PlayState.Dissatisfy)
        {
            PlayStatManager.instance.DissatisfyRate += add;
        }
        else if (playState == PlayState.Comfort)
        {
            PlayStatManager.instance.ComfortRate += add;
        }
        else if (playState == PlayState.Crime)
        {
            PlayStatManager.instance.CrimeRate += add;
        }
        else if (playState == PlayState.Trade)
        {
            PlayStatManager.instance.TradeRate += add;
        }
        else if (playState == PlayState.Food)
        {
            PlayStatManager.instance.Food += add;
        }
    }
}

public enum KingAbility { AdministrativePower, EconomicPower, WarPower }
public enum PlayState { Briket, Tax, Dissatisfy, Comfort, Crime, Trade, Food }
