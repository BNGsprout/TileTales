using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelEndTrigger : MonoBehaviour
{
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 8)
        {
            var session = FindFirstObjectByType<GameSession>();
            var highScore = FindFirstObjectByType<HighScoreManager>();

            highScore.CheckHighScore(session.CurrentScore);
        }
    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        var session = FindFirstObjectByType<GameSession>();
    //        var highScore = FindFirstObjectByType<HighScoreManager>();

    //        highScore.CheckHighScore(session.CurrentScore);

            
    //    }
    //}
}   