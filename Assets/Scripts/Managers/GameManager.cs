using Player;
using UnityEngine;
using UnityEngine.SceneManagement;


enum Scenes
{
    WinScene,
    MainMenu
}
public class GameManager: MonoBehaviour
{
    private Scenes _scenes;
    
    
    public void Update()
    {
        if (ScoreManager.score >= 10)
        {
            SceneManager.LoadScene($"WinScene");
        }
        
        if (HealthManager.lives <= 0)
        {
            SceneManager.LoadScene($"MainMenu");
        }
    }
    
}