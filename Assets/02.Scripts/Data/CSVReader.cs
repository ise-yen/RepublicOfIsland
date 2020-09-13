
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour
{
    private void Awake()
    {
        DataParse();
    }

    void DataParse()
    {
        StreamReader sr = new StreamReader(Application.dataPath + "/EventData.csv");

        string data_firstStr = sr.ReadLine();

        bool endOfFile = false;
        while (!endOfFile)
        {
            string data_str = sr.ReadLine();
            if (data_str == null)
            {
                endOfFile = true;
                break;
            }

            ParseData(data_str);
        }
    }

    void ParseData(string data)
    {
        string[] parsed_str = data.Split(',');
        int date_Y = int.Parse(parsed_str[0]);
        int date_M = int.Parse(parsed_str[1]);

        string title = parsed_str[2];
        string content = parsed_str[3];

        string[] eventSelections = parsed_str[4].Split('\'');
        string[] affects_str = parsed_str[5].Split('\'');
        int[] affects_int = new int[affects_str.Length];
        for (int i = 0; i < affects_int.Length; i++)
        {
            affects_int[i] = int.Parse(affects_str[i]);
        }

        string[] additionalBox = parsed_str[6].Split('\'');
        string[] effectStat = parsed_str[7].Split('\'');
        Debug.Log(date_Y);
        EventData.eventList.Add(new EventType
        { 
            
            date_Y = date_Y,
            date_M = date_M,
            title = title,
            eventContents = content,
            eventSelection = eventSelections,
            eventAdditionalBox = additionalBox,
            effectType = effectStat
        });
    }

    void IntializeUserStat(UserData userData)
    {
    }
}
