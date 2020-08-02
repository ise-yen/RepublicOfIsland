﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    public static AbilityManager instance;
    public enum PlayerAbility { administrativePower = 2, economicPower = 2, warMachine = 2 }

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

    public void ObtainAbility(PlayerAbility a, int add)
    {
        Debug.Log("능력치가 <" + add + ">만큼 추가되었습니다.");
        Debug.Log("능력치: " + (int)a + add);
    }

}