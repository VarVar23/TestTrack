using System.IO;
using UnityEngine;

public class SaveToJson
{
    public static SaveToJson Instance;

    private string _savePath;
    private string _fileName;
    private ResultSO _resultSO;

    public SaveToJson(ResultSO resultSO)
    {
        _resultSO = resultSO;
        Instance = this;
    }

    public void Awake()
    {
        _fileName = "SaveData";
        _savePath = Path.Combine(Application.dataPath, _fileName);
        LoadFile();
    }

    public void SaveToFile()
    {
        string json = JsonUtility.ToJson(SaveData.Instance, true);
        File.WriteAllText(_savePath, json);
    }

    public void LoadFile()
    {
        if (!File.Exists(_savePath))
        {
            SaveData.Instance.ResultText = _resultSO.DefaultResultText;
            SaveToFile();
            return;
        }

        string json = File.ReadAllText(_savePath);
        SaveData.Instance = JsonUtility.FromJson<SaveData>(json);
    }
}