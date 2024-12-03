using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private string saveFilePath;

    private void Awake()
    {
        // Define the path for the save file
        saveFilePath = Application.persistentDataPath + "/savefile.json";
    }

    public void SaveGame(SaveData data)
    {
        // Convert data to JSON format
        string json = JsonUtility.ToJson(data);

        // Write JSON to the file
        File.WriteAllText(saveFilePath, json);

        Debug.Log("Game Saved to " + saveFilePath);
    }

    public SaveData LoadGame()
    {
        if (File.Exists(saveFilePath))
        {
            // Read JSON from the file
            string json = File.ReadAllText(saveFilePath);

            // Convert JSON back to SaveData
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Debug.Log("Game Loaded from " + saveFilePath);

            return data;
        }
        else
        {
            Debug.LogWarning("Save file not found!");
            return null;
        }
    }
}
