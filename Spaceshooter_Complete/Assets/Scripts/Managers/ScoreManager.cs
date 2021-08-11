using UnityEngine;

namespace Managers
{
    public class ScoreManager: MonoBehaviour
    {
        public static int Score {get; private set;}
    
        public void AddScore()
        {
            Score++;
        }
    }
}