using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixingEvent : MonoBehaviour
{
    //요소: 날짜, 내용, 선택지
    //Dictionary<int, string[]> SelectionData;

    int count = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OccuringEvent();
        }

    }

    void OccuringEvent()
    {
        TimeCount.instance.TimeUp();
        count++;
        if (count == 1)
        {
            WelcomeEvent();
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("확인1");
                //AbilityManager.instance.ObtainAbility(AbilityManager.PlayerAbility.administrativePower, 1);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("확인2");
                //AbilityManager.instance.ObtainAbility(AbilityManager.PlayerAbility.economicPower, 1);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                Debug.Log("확인3");
                //AbilityManager.instance.ObtainAbility(AbilityManager.PlayerAbility.warMachine, 1);
            }
        }
        if (count == 2) MafiaEvent();
        if (count == 13) NewYearEvent();
        if (count == 27) KingGraceEvent();
        if (count == 52) KingThinkEvent();
        if (count == 57) KingMarryEvent();
        if (count == 61) MurderEvent();
        if (count == 62) CleanEvent();
        if (count == 12 * 8) TrashEvent();
        if (count == 109) OppositionEvent();
        if (count == 121) TenEvent();
    }

    void WelcomeEvent()
    {
        Debug.Log("Welcome to ROI");
        Debug.Log("1. 행정력 +1");
        Debug.Log("2. 경제력 +1");
        Debug.Log("3. 군사력 +1");

    }

    void MafiaEvent()
    {
        Debug.Log("밤이 지났습니다. 마피아는 일어나 주세요");
        Debug.Log("1. 브리킷 -3");
        Debug.Log("2. 브리킷 -3");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
    }
    void NewYearEvent()
    {
        Debug.Log("새해 복 많이 받으세요!");
        Debug.Log("1. 브리킷 +30");
        Debug.Log("2. 행정력 +1");
        Debug.Log("3. 범죄율 -1%, 불만도+1");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            AbilityManager.instance.ObtainAbility(AbilityManager.PlayerAbility.administrativePower, 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            AbilityManager.instance.ObtainAbility(AbilityManager.PlayerAbility.economicPower, 1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            AbilityManager.instance.ObtainAbility(AbilityManager.PlayerAbility.warMachine, 1);
        }
    }
    void KingGraceEvent()
    {
        Debug.Log("왕 축복");
        Debug.Log("1. 브리킷 +30");
        Debug.Log("2. 브리킷 -30, 무역력 +1");
        Debug.Log("3. 가톨릭 +5%, 이슬람 -5%");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            KingThinkEvent();
        }
    }
    void KingThinkEvent()
    {
        Debug.Log("왕 고민");
        Debug.Log("1. 안정도 -1");
        Debug.Log("2. 가톨릭 +5%, 이슬람 -5%");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            KingMarryEvent();
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
    }
    void KingMarryEvent()
    {
        Debug.Log("왕 결혼");
        Debug.Log("1. 이슬람 +70%, 가톨릭 =30%");
        Debug.Log("2. 브리킷 +30");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
    }
    void MurderEvent()
    {
        Debug.Log("살인사건");
        Debug.Log("1. 안정도 -1, 범죄율 +5%");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
    }
    void CleanEvent()
    {
        Debug.Log("범죄X");
        Debug.Log("1. 브리킷 -100, 범죄률 -5%");
        Debug.Log("2. 법원 건설 -50");
        Debug.Log("3. 브리킷 +30, 범죄률 +5%");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
        }
    }
    void TrashEvent()
    {
        Debug.Log("쓰레기");
        Debug.Log("1. 안정도 -1");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
    }
    void OppositionEvent()
    {
        Debug.Log("가톨릭 대립");
        Debug.Log("1. 안정도 -1, 불만도 -1, 브리킷 -30");
        Debug.Log("2. 가톨릭 -20%, 기독교 +15%");
        Debug.Log("3. 안정도 -1, 브리킷 -20, 이슬람 +10%");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
    }
    void TenEvent()
    {
        Debug.Log("10주년");
        Debug.Log("1. 식량 저장량 +2");
        Debug.Log("2. 메인 종교지지도 +10%, 그 외 -5%");
        Debug.Log("3. 왕 능력치 랜덤 +1");
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
    }
}
