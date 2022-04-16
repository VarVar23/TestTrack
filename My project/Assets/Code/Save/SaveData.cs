using System;

[Serializable]
public class SaveData
{
    public static SaveData Instance;
    public SaveData() => Instance = this;

    public string ResultText;
    public string ResultTime;
}
