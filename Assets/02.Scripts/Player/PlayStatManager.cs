using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStatManager : MonoBehaviour
{
    public static PlayStatManager instance;

    //브리킷, 세금, 불만도, 안정도, 범죄율, 무역력, 식량
    public float briket = 0;
    public float Briket { get { return briket; } set { briket = value; } }

    public float tax = 0;
    public float Tax { get { return tax; } set { tax = value; } }

    public float dissatisfyRate = 2;
    public float DissatisfyRate { get { return dissatisfyRate; } set { dissatisfyRate = value; } }

    public float comfortRate = 0;
    public float ComfortyRate { get { return comfortRate; } set { comfortRate = value; } }
    
    public float crimeRate = 2;
    public float CrimeRate { get { return crimeRate; } set { crimeRate = value; } }
    
    public float tradeRate = 1;
    public float TradeRate { get { return tradeRate; } set { tradeRate = value; } }

    public float food = 3;
    public float Food { get { return food; } set { food = value; } }

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
