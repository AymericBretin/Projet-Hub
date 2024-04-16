using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class WriteJson : MonoBehaviour
{
    public SaveData data = new SaveData();
    public GameManager gameManager;
    public GameObject text;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public void SaveJson()
    {
        Debug.Log("Game Save");
        data.Level = gameManager.Level_End;
        data.Monde = gameManager.world;
        data.IgSecond = gameManager.TimeSecond;
        data.IgMinute = gameManager.TimeMinute;
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/Save.json", json);
        text.SetActive(true);
        StartCoroutine(SaveGame());
    }

    public void LoadJson()
    {
        Debug.Log("Save Load");
        string json = File.ReadAllText(Application.dataPath + "/Save.json");
        SaveData data = JsonUtility.FromJson<SaveData>(json);
        gameManager.Level_End = data.Level;
        gameManager.world = data.Monde;
        gameManager.TimeSecond = data.IgSecond;
        gameManager.TimeMinute = data.IgMinute;
    }

    public void AddToJson()
    {
        data.Level = gameManager.Level_End;
    }

    IEnumerator SaveGame()
    {
        yield return new WaitForSeconds(1);
        text.SetActive(false);
    }
}
