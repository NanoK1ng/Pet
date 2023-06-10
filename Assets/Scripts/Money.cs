using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu (fileName = "Money", order = 1)]
public class Money : ScriptableObject
{
    public int Coins = 0;

    private const string FILENAME = "Money.dat";

    public void SaveToFile()
    {
        var filePath = Path.Combine(Application.persistentDataPath, FILENAME);

        if (!File.Exists(filePath))
        {
            File.Create(filePath);
        }

        var json = JsonUtility.ToJson(this);
        File.WriteAllText(filePath, json);
    }


    public void LoadDataFromFile()
    {
        var filePath = Path.Combine(Application.persistentDataPath, FILENAME);

        if (!File.Exists(filePath))
        {
            Debug.LogWarning($"File \"{filePath}\" not found!", this);
            return;
        }

        var json = File.ReadAllText(filePath);
        JsonUtility.FromJsonOverwrite(json, this);
    }
}