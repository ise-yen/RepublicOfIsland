using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReligionSystem : MonoBehaviour
{
    //Enum
    enum Religions { Catholic, Christian, Islam } //종교 종류
    //Religions mainReligion; //메인 종교
    string[] religions = new string[] { "Catholic", "Christian", "Islam" }; // 종교 종류
    string mainReligion;
    public int religionSupport; //종교지지도
    int catholic = 70; //천주교
    int christian = 0; //기독교
    int islam = 30; //이슬람

    void Start()
    {
        mainReligion = religions[0];
        Debug.Log("초기 메인 종교: " + mainReligion);
        Debug.Log("[천주교/기독교/이슬람] : " + catholic + "%/" + christian + "%/" + islam + "%");

    }

    void Update()
    {
        //EventingReligionSupport();
        ChangingReligion();
    }

    void OperatingChristian()
    {
        //수정 필요
        Debug.Log("<기독교 이벤트 발생>");
    }

    void EventingReligionSupport()
    {
        if (religionSupport < 70)
        {
            Debug.Log("<<종교 지지도 고정 이벤트 발생>>");
            if (religionSupport % 10 == 0)
            {
                Debug.Log("<종교 지지도 " + religionSupport + "% 고정 이벤트 발생>");
            }
        }
        if (religionSupport == 100)
        {
            Debug.Log("<종교 지지도 100% 고정 이벤트 발생>");
        }
    }

    void ChangingReligion()
    {//수정enum
        Debug.Log("<종교 바꾸기 이벤트 발생>");
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            mainReligion = religions[0];
            Debug.Log("Press 0");

        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            mainReligion = religions[1];
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            mainReligion = religions[2];
        }
        Debug.Log("메인 종교: " + mainReligion);
    }
}
