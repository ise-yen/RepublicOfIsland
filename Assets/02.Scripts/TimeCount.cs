using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    public static TimeCount instance;
    public int year = 1400;
    public int month = 0;
    public int count = 0;
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

    public void TimeUp()
    {
        if (month == 12)
        {
            month = 1;
            year++;
        }
        else
            month++;
        Debug.Log(year + "년 " + month + "일");
        count++;
    }
}
