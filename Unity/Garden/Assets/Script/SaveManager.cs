using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager 
{

    //Money and bag Save and load 
   public static void SaveGame(BagScript bag)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.weed";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData(bag);


        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static SaveData LoadGame()
    {
        string path = Application.persistentDataPath + "/player.weed";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(stream) as SaveData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Savefile not found in " + path);
            return null;
        }
    }

    //Save and load for Pot places and plants ans skins 
    public static void SaveGameP(PotPlaces places)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerP.weed";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveDataPots data = new SaveDataPots(places);


        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static SaveDataPots LoadGameP()
    {
        string path = Application.persistentDataPath + "/playerP.weed";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveDataPots dataP = formatter.Deserialize(stream) as SaveDataPots;
            stream.Close();

            return dataP;
        }
        else
        {
            Debug.LogError("Savefile not found in " + path);
            return null;
        }
    }
    //Save and load for Pot places and plants ans skins 
    public static void SaveGameI(Inventory Invent)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerI.weed";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveDataInv data = new SaveDataInv(Invent);


        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static SaveDataInv LoadGameI()
    {
        string path = Application.persistentDataPath + "/playerI.weed";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveDataInv dataI = formatter.Deserialize(stream) as SaveDataInv;
            stream.Close();

            return dataI;
        }
        else
        {
            Debug.LogError("Savefile not found in " + path);
            return null;
        }
    }




}
