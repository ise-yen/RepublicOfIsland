using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingAbilityManager : MonoBehaviour
{
    public static KingAbilityManager instance;

    //왕의 능력치: 행정력, 경제력, 군사력
    int administrativePower = 2;
    public int AdministrativePower { get { return administrativePower; } set { administrativePower = value; } }

    int economicPower = 2;
    public int EconomicPower { get { return economicPower; } set { economicPower = value; } }

    int warPower = 2;
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

}
