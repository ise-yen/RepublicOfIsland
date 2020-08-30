using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManager : MonoBehaviour
{
    public static void SaveData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.dat";
        FileStream stream = new FileStream(path, FileMode.Create);

        UserData userData = new UserData(RoundManager.instance, PlayStatManager.instance, KingAbilityManager.instance);

        formatter.Serialize(stream, userData);
        stream.Close();

    }

    public static UserData LoadData()
    {
        string path = Application.persistentDataPath + "/player.dat";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            UserData data = formatter.Deserialize(stream) as UserData;
            stream.Close();
            
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}

[System.Serializable]
public class UserData
{
    public int date_Y;
    public int date_M;

    public int[] abilities;
    public int[] states;

    //public int[] buildingLevel;

    public UserData(RoundManager rm, PlayStatManager psm, KingAbilityManager km)
    {
        date_Y = rm.date_Y;
        date_M = rm.date_M;

        abilities = new int[3] { km.AdministrativePower, km.EconomicPower, km.WarPower };
        states = new int[7] { psm.Briket, psm.Tax, psm.DissatisfyRate, psm.ComfortRate, psm.CrimeRate, psm.TradeRate, psm.Food };
    }
}
