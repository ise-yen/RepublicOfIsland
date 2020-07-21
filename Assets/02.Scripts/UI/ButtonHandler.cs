using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => { RoundManager.instance.EndRound("눈이 녹고 있는 중"); });
    }
}
