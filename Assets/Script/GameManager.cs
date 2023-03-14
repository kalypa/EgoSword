using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField]
    private User user = null;
    [SerializeField]
    private Attribute attribute = null;
    public User CurrentUser { get { return user; } }

    private UIManager uiManager;


    public UIManager UI
    {
        get
        {
            if (uiManager == null)
            {
                uiManager = GetComponent<UIManager>();
            }
            return uiManager;
        }
    }

    private Canvas canvas = null;

    public Canvas Canvas
    {
        get
        {
            if (canvas == null)
            {
                canvas = FindObjectOfType<Canvas>();
            }
            return canvas;
        }
    }

    [SerializeField]
    private Transform poolManager = null;
    public Transform Pool { get { return poolManager; } }

    private string SAVE_PATH = "";
    private string SAVE_FILENAME = "/SaveFile.txt";
    private void Awake()
    {
        SAVE_PATH = Application.persistentDataPath + "/Save";
        if (!Directory.Exists(SAVE_PATH))
        {
            Directory.CreateDirectory(SAVE_PATH);
        }
        LoadFromJson();
    }

    private void Start()
    {

        InvokeRepeating("SaveToJson", 1f, 60f);
        InvokeRepeating("EarnJewelPerSecond", 0f, 1f);

    }

    private void EarnJewelPerSecond()
    {
        foreach (Pickaxe pickaxe in user.pickaxeList)
        {
            user.jewel += pickaxe.ePs * pickaxe.amount;
        }
        UI.UpdateJewelPanel();

    }

    private void LoadFromJson()
    {
        if (File.Exists(SAVE_PATH + SAVE_FILENAME))
        {
            string json = File.ReadAllText(SAVE_PATH + SAVE_FILENAME);
            user = JsonUtility.FromJson<User>(json);
        }
    }

    private void SaveToJson()
    {
        string json = JsonUtility.ToJson(user, true);
        File.WriteAllText(SAVE_PATH + SAVE_FILENAME, json, System.Text.Encoding.UTF8);
    }

    private void OnApplicationQuit()
    {
        SaveToJson();
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
