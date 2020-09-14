using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public void OnClickButton(string param)
    {
        AudioManager.instance.PlayEffectAudio("Effect_Click");
        switch(param)
        {
            case "Close":
                transform.parent.gameObject.SetActive(false);
                break;
            case "RoundEnd":
                RoundManager.instance.EndRound("턴이 넘어가는 중...");
                break;
            case "ShowEventData":
                UIManager.instance.ShowEventDataList();
                break;
            case "NewGame":
                GlobalManager.instance.StartGame();
                break;
            case "LoadGame":
                GlobalManager.instance.LoadGame();
                break;
        }
    }
}
