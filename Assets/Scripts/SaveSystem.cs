using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveShop(Shop shop)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/shop.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        ShopData data = new ShopData(shop);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ShopData LoadShop()
    {
        string path = Application.persistentDataPath + "/shop.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ShopData data = formatter.Deserialize(stream) as ShopData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File Not Found in " + path);
            return null;
        }
    }
}
