using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager: MonoBehaviour
{
    public void Update()
    {
        if (ScoreManager.score >= 10)
        {
            SceneManagement.LoadScene("WinScene");
        }
        
        if (HealthManager.lives <= 0)
        {
            SceneManagement.LoadScene("MainMenu")
        }
    }
    
}