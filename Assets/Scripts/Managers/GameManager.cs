using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager: MonoBehaviour
    {
        public void Update()
        {
            if (ScoreManager.Score >= 10)
            {
                SceneManager.LoadScene($"WinScene");
            }
        
            if (HealthManager.lives <= 0)
            {
                SceneManager.LoadScene($"MainMenu");
            }
        }
    
    }
}