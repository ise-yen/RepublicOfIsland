using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    #region Ability Settings
    public enum ABILITY { Tax, Dissatisfy, Comfort, Crime, Trade, Food }
    public Transform[] abilityText;
    #endregion

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }

    public void SetAbilityUI(ABILITY ability, string param)
    {
        abilityText[(int)ability].GetComponentInChildren<Text>().text = param;
    }
}
