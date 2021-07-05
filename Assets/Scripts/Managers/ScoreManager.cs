using UnityEngine;

public class ScoreManager: MonoBehaviour
{
    public static int score {get; private set;}
    
    public void AddScore()
    {
        score++;
    }
}