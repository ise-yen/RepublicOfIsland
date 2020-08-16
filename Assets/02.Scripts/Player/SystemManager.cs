using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public static SystemManager instance;

    //브리킷, 세금, 불만도, 안정도, 범죄율, 무역력
    public float briket;
    public float dissatisfyRate;
    public float stabilityRate;
    public float crimeRate;
    public float tradeRate;
    //public enum SystemState { Briket, DissatisfyRate, StabilityRate, CrimeRate, TradeRate }

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
