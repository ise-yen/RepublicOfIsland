using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchBuilt : MonoBehaviour
{
    //건물을 담을 오브젝트
    public GameObject FirstChurch;
    public GameObject SecondChurch;
    public GameObject ThirdChurch;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BuildFirstChurch();
            BuildSecondChurch();
            BuildThirdChurch();
            Debug.Log("교회 생성 완료");
        }
    }

    public void BuildFirstChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "ChurchPlane")
        {
            //PlayStatManager.instance.Briket -= 125;
            PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Briket, -125);
            Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

            //KingAbilityManager.instance.AdministrativePower -= 400;
            //UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);
            PlayerSystemManager.instance.ObtainKingAbility(PlayerSystemManager.KingAbility.AdministrativePower, -400);
            Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

            //PlayStatManager.instance.Food -= 1;
            //UIManager.instance.SetPlayerStat(UIManager.PLAYERSTAT.Food, PlayStatManager.instance.Food);
            PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Food, -1);
            Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

            FirstChurch.SetActive(true);
            Debug.Log("1단계 교회 생성");
        }
    }
    public void BuildSecondChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "Church1")
        {
            //PlayStatManager.instance.Briket -= 250;
            PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Briket, -250);
            Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
          
            //KingAbilityManager.instance.AdministrativePower -= 600;
            //UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);
            PlayerSystemManager.instance.ObtainKingAbility(PlayerSystemManager.KingAbility.AdministrativePower, -600);
            Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
            
            //PlayStatManager.instance.Food -= 3;
            //UIManager.instance.SetPlayerStat(UIManager.PLAYERSTAT.Food, PlayStatManager.instance.Food);
            PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Food, -3);
            Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

            FirstChurch.SetActive(false);
            SecondChurch.SetActive(true);
            Debug.Log("2단계 교회 생성");
        }
    }
    public void BuildThirdChurch()
    {
        RayHitting.instance.ClickObject();
        if (RayHitting.instance.SelectObj.name == "Church2")
        {
            //PlayStatManager.instance.Briket -= 500;
            PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Briket, -500);
            Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
            
            //KingAbilityManager.instance.AdministrativePower -= 800;
            //UIManager.instance.SetAbilityUI(KingAbilityManager.instance.AdministrativePower, KingAbilityManager.instance.EconomicPower, KingAbilityManager.instance.WarPower);
            PlayerSystemManager.instance.ObtainKingAbility(PlayerSystemManager.KingAbility.AdministrativePower, -800);
            Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
            
            //PlayStatManager.instance.Food -= 5;
            //UIManager.instance.SetPlayerStat(UIManager.PLAYERSTAT.Food, PlayStatManager.instance.Food);
            PlayerSystemManager.instance.StatingStat(PlayerSystemManager.PlayState.Food, -5);
            Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

            SecondChurch.SetActive(false);
            ThirdChurch.SetActive(true);
            Debug.Log("3단계 교회 생성");
        }
    }
}