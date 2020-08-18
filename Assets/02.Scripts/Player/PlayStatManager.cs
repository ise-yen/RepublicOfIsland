using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStatManager : MonoBehaviour
{
    public static PlayStatManager instance;

    //브리킷, 세금, 불만도, 안정도, 범죄율, 무역력, 식량
    int briket = 0;
    public int Briket { get { return briket; } set { briket = value; } }

    int tax = 0;
    public int Tax { get { return tax; } set { tax = value; } }

    int dissatisfyRate = 2;
    public int DissatisfyRate { get { return dissatisfyRate; } set { dissatisfyRate = value; } }

    int comfortRate = 0;
    public int ComfortRate { get { return comfortRate; } set { comfortRate = value; } }
    
    int crimeRate = 2;
    public int CrimeRate { get { return crimeRate; } set { crimeRate = value; } }
    
    int tradeRate = 1;
    public int TradeRate { get { return tradeRate; } set { tradeRate = value; } }

    int food = 3;
    public int Food { get { return food; } set { food = value; } }

    //public enum PlayStatState { Briket, DissatisfyRate, ComfortRate, CrimeRate, TradeRate, Food }

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