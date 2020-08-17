using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabilitySystem : MonoBehaviour
{
    //안정도 시스템
    public int stability = 0; //안정도: 0으로 시작해서 -가 됨
    //종교 지지도랑 안정도 연결
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            stability = ConfirmStability();
        }

    }
    int ConfirmStability()
    {
        Debug.Log("현재 안정도 : " + stability);
        return stability;
    }

    void EventingStability()
    {
        if (stability == -5)
        {
            Debug.Log("<<G A M E   O V E R>>");

        }
        if (stability == -3)
        {
            Debug.Log("<안전도 -3 고정 이벤트 발생>");
        }
    }
}
