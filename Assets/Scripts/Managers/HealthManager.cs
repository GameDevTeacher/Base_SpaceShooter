using UnityEngine;

namespace Managers
{
    public class HealthManager : MonoBehaviour
    {
        public static int lives = 3;
        private const int MAXLives = 3;
        
        private void Awake()
        {
            lives = MAXLives;
        }
        
        public void SetLives(int value)
        {
            lives = value;
        }
        
        public void AddLives()
        {
            lives++;
        }
        
        public void ReduceLives()
        {
            lives--;
        }
    }
}
