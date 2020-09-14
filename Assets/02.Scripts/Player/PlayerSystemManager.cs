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

    private void Start()
    {
    }

    public void InitializeStat(UserData userData)
    {
        if (userData != null)
        {
            KingAbilityManager.instance.AdministrativePower = userData.abilities[0];
            KingAbilityManager.instance.EconomicPower = userData.abilities[1];
            KingAbilityManager.instance.WarPower = userData.abilities[2];

            UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);

            PlayStatManager.instance.Briket = userData.states[0];
            PlayStatManager.instance.Tax = userData.states[1];
            PlayStatManager.instance.DissatisfyRate = userData.states[2];
            PlayStatManager.instance.ComfortRate = userData.states[3];
            PlayStatManager.instance.CrimeRate = userData.states[4];
            PlayStatManager.instance.TradeRate = userData.states[5];
            PlayStatManager.instance.Food = userData.states[6];

            UIManager.instance.SetPlayerStat(PlayState.Tax, PlayStatManager.instance.Tax);
            UIManager.instance.SetPlayerStat(PlayState.Dissatisfy, PlayStatManager.instance.DissatisfyRate);
            UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);
            UIManager.instance.SetPlayerStat(PlayState.Crime, PlayStatManager.instance.CrimeRate);
            UIManager.instance.SetPlayerStat(PlayState.Trade, PlayStatManager.instance.TradeRate);
            UIManager.instance.SetPlayerStat(PlayState.Food, PlayStatManager.instance.Food);
        }
        else
        {
            KingAbilityManager.instance.AdministrativePower = 2;
            KingAbilityManager.instance.EconomicPower = 2;
            KingAbilityManager.instance.WarPower = 2;

            UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);

            PlayStatManager.instance.Briket = 0;
            PlayStatManager.instance.Tax = 0;
            PlayStatManager.instance.DissatisfyRate = 2;
            PlayStatManager.instance.ComfortRate = 0;
            PlayStatManager.instance.CrimeRate = 2;
            PlayStatManager.instance.TradeRate = 1;
            PlayStatManager.instance.Food = 3;

            UIManager.instance.SetPlayerStat(PlayState.Tax, PlayStatManager.instance.Tax);
            UIManager.instance.SetPlayerStat(PlayState.Dissatisfy, PlayStatManager.instance.DissatisfyRate);
            UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);
            UIManager.instance.SetPlayerStat(PlayState.Crime, PlayStatManager.instance.CrimeRate);
            UIManager.instance.SetPlayerStat(PlayState.Trade, PlayStatManager.instance.TradeRate);
            UIManager.instance.SetPlayerStat(PlayState.Food, PlayStatManager.instance.Food);
        }
    }

    public void ObtainKingAbility(KingAbility kingAbility, int add)
    {
        if (kingAbility == KingAbility.AdministrativePower)
        {
            KingAbilityManager.instance.AdministrativePower += add;
            UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);
        }
        else if (kingAbility == KingAbility.EconomicPower)
        {
            KingAbilityManager.instance.EconomicPower += add;
            UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);
        }
        else if (kingAbility == KingAbility.WarPower)
        {
            KingAbilityManager.instance.WarPower += add;
            UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);
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
            UIManager.instance.SetPlayerStat(PlayState.Tax, PlayStatManager.instance.Tax);
        }
        else if (playState == PlayState.Dissatisfy)
        {
            PlayStatManager.instance.DissatisfyRate += add;
            UIManager.instance.SetPlayerStat(PlayState.Dissatisfy, PlayStatManager.instance.DissatisfyRate);
        }
        else if (playState == PlayState.Comfort)
        {
            PlayStatManager.instance.ComfortRate += add;
            UIManager.instance.SetPlayerStat(PlayState.Comfort, PlayStatManager.instance.ComfortRate);
        }
        else if (playState == PlayState.Crime)
        {
            PlayStatManager.instance.CrimeRate += add;
            UIManager.instance.SetPlayerStat(PlayState.Crime, PlayStatManager.instance.CrimeRate);
        }
        else if (playState == PlayState.Trade)
        {
            PlayStatManager.instance.TradeRate += add;
            UIManager.instance.SetPlayerStat(PlayState.Trade, PlayStatManager.instance.TradeRate);
        }
        else if (playState == PlayState.Food)
        {
            PlayStatManager.instance.Food += add;
            UIManager.instance.SetPlayerStat(PlayState.Food, PlayStatManager.instance.Food);
        }
    }
}

public enum KingAbility { AdministrativePower, EconomicPower, WarPower }
public enum PlayState { Briket, Tax, Dissatisfy, Comfort, Crime, Trade, Food }
