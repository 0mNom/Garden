using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager 
{
   public static void SaveGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.weed";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData();


        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static SaveData LoadGame ()
    {
        string path = Application.persistentDataPath + "/player.weed";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data =  formatter.Deserialize(stream)as SaveData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Savefile not found in " + path);
            return null;
        }
    }
}
