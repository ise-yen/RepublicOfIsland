using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReligionManager : MonoBehaviour
{
    public static ReligionManager instance;
    
    //종교: 가톨릭, 크리스천, 이슬람
    public enum Religion { Catholic, Christian, Islam }
    public Religion religionState = Religion.Catholic;

    //종교지지도
    int mainReligion;
    public int MainReligion { get { return mainReligion; } set { mainReligion = value; } }

    //천주교
    int catholic = 70;
    public int Catholic { get { return catholic; } set { catholic = value; } }

    //기독교
    int christian = 0;
    public int Christian { get { return christian; } set { christian = value; } }

    //이슬람
    int islam = 30;
    public int Islam { get { return islam; } set { islam = value; } }
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

    public int StatingReligion(Religion religionState)
    {
        if (religionState == Religion.Catholic)
        {
            MainReligion = Catholic;
        }
        else if (religionState == Religion.Christian)
        {
            MainReligion = Christian;
        }
        else if (religionState == Religion.Islam)
        {
            MainReligion = Islam;
        }

        Debug.Log("메인 종교: " + mainReligion);
        return MainReligion;
    }


}
