using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class HealthManager : MonoBehaviour
    {
    
        public int lives = 3;
        private int maxLives = 3;
        
        // Start is called before the first frame update
        void Start()
        {
            lives = maxLives;
        }

        // Update is called once per frame
        void Update()
        {
            if (lives == 0)
            {
                SceneManagement.LoadScene()
            }
            
        }
    }
}
