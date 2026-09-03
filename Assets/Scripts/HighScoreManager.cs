using UnityEngine;
using System.IO;

[System.Serializable]
public class HighScoreData
{
    public int highScore;
}

public class HighScoreManager : MonoBehaviour
{
    private string savePath;
    private HighScoreData data;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        savePath = Path.Combine(Application.persistentDataPath, "highscore.json");
        Load();
    }

    private void Load()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            data = JsonUtility.FromJson<HighScoreData>(json);
        }
        else
        {
            data = new HighScoreData();
        }
    }

    public void CheckHighScore(int currentScore)
    {
        if (currentScore > data.highScore)
        {
            data.highScore = currentScore;
            Save();
            Debug.Log("New high score: " + data.highScore);
        }
    }

    private void Save()
    {
        File.WriteAllText(savePath, JsonUtility.ToJson(data));
    }

    public int GetHighScore() => data.highScore;
}   