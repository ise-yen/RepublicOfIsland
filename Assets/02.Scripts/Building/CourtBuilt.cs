using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtBuilt : MonoBehaviour
{
    //GameObject target;
    //건물을 담을 오브젝트
    public GameObject FirstCourt;
    public GameObject SecondCourt;
    public GameObject ThirdCourt;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayHitting.instance.ClickObject();
            if(RayHitting.instance.SelectObj != null)
            {
                Debug.Log("target: " + RayHitting.instance.SelectObj.name);
                if (RayHitting.instance.SelectObj.name == "courtPlane")
                {
                    RayHitting.instance.SelectObj.SetActive(false);
                    BuildFirstCourt();
                }
                if (RayHitting.instance.SelectObj.name == "court1")
                {
                    BuildSecondCourt();
                }
                if (RayHitting.instance.SelectObj.name == "court2")
                {
                    BuildThirdCourt();
                }
            }
        }

    }
    public void BuildFirstCourt()
    {
        //RayHitting.instance.ClickObject();
        //RayHitting.instance.Target = RayHitting.instance.GetClickedObject();

        //PlayStatManager.instance.Briket -= 100;
        //Debug.Log("브리킷: "+ PlayStatManager.instance.Briket);
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -100);
        //Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);

        //Debug.Log("행정력: " + KingAbilityManager.instance.AdministrativePower);
        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -250);
        //Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        //Debug.Log("식량: " + PlayStatManager.instance.Food);
        PlayerSystemManager.instance.StatingStat(PlayState.Food, -1);
        //Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstCourt.SetActive(true);
    }
    public void BuildSecondCourt()
    {
        //RayHitting.instance.ClickObject();
        //RayHitting.instance.Target = RayHitting.instance.GetClickedObject();

        //Debug.Log("브리킷: "+ PlayStatManager.instance.Briket);
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -200);
        //Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
      
        //Debug.Log("행정력: " + KingAbilityManager.instance.AdministrativePower);
        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -450);
        //Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);

        //Debug.Log("식량: " + PlayStatManager.instance.Food);
        PlayerSystemManager.instance.StatingStat(PlayState.Food, -2);
        //Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        FirstCourt.SetActive(false);
        SecondCourt.SetActive(true);
    }
    public void BuildThirdCourt()
    {
        //RayHitting.instance.ClickObject();
        //RayHitting.instance.Target = RayHitting.instance.GetClickedObject();

        //Debug.Log("브리킷: "+ PlayStatManager.instance.Briket);
        PlayerSystemManager.instance.StatingStat(PlayState.Briket, -300);
        //Debug.Log("잔여 브리킷: " + PlayStatManager.instance.Briket);
       
        //Debug.Log("행정력: " + KingAbilityManager.instance.AdministrativePower);
        PlayerSystemManager.instance.ObtainKingAbility(KingAbility.AdministrativePower, -600);
        //Debug.Log("잔여 행정력: " + KingAbilityManager.instance.AdministrativePower);
     
        //Debug.Log("식량: " + PlayStatManager.instance.Food);
        PlayerSystemManager.instance.StatingStat(PlayState.Food, -3);
        //Debug.Log("잔여 식량: " + PlayStatManager.instance.Food);

        SecondCourt.SetActive(false);
        ThirdCourt.SetActive(true);
    }
}
