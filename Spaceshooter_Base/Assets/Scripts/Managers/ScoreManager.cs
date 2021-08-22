using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Managers
{
    public class ScoreManager: MonoBehaviour
    {
        public static int Score {get; private set;}
        
       [SerializeField] private UnityEvent _setScore;
        
        public static void AddScore()
        {
            Score++;
        }

        public void SetScoreUI(Text _text)
        {
            _text.text = "Score : " + Score.ToString();
        }
        
        public void SetScoreUI(TMP_Text _tmpText)
        {
            _tmpText.text = "Score : " + Score.ToString();
        }

        private void Update()
        {
            _setScore.Invoke();
        }
    }
}