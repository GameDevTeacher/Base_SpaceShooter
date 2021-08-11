using UnityEngine;
using UnityEngine.InputSystem;

namespace Managers
{
    public class GameManager: MonoBehaviour
    {
        [Scene] public string winScene, mainMenu;
        
        public void Update()
        {
            if (ScoreManager.Score >= 10)
            {
                SceneController.LoadSceneStatic(winScene);
            }
        
            if (HealthManager.lives <= 0)
            {
                SceneController.LoadSceneStatic(mainMenu);
            }

            if (Keyboard.current.escapeKey.wasPressedThisFrame)
            {
                SceneController.LoadSceneStatic(mainMenu);
            }
        }
    }
}