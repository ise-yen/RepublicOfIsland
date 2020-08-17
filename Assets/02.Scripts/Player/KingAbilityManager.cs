using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingAbilityManager : MonoBehaviour
{
    public static KingAbilityManager instance;

    //public enum KingAbility { administrativePower = 2, economicPower = 2, warPower = 2 }

    //왕의 능력치: 행정력, 경제력, 군사력
    public int administrativePower = 2;
    public int AdministrativePower { get { return administrativePower; } set { administrativePower = value; } }

    public int economicPower = 2;
    public int EconomicPower { get { return economicPower; } set { economicPower = value; } }

    public int warPower = 2;
    public int WarPower { get { return warPower; } set { warPower = value; } }

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
    /*
    public void ObtainAbility(PlayerAbility a, int add)
    {
        Debug.Log("능력치가 <" + add + ">만큼 추가되었습니다.");
        Debug.Log("능력치: " + (int)a + add);
    }
    */
}
