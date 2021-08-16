using System.Collections;
using UnityEngine;

namespace Player
{
    public class EngineFire : MonoBehaviour
    {
        [SerializeField] private GameObject _engineFlame;

        private Input _input;

        private readonly int frameInterval = 15;

        // Start is called before the first frame update
        private void Start()
        {
            _input = GetComponent<Input>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Time.frameCount % frameInterval == 0)
            {
                if (_input.MoveVector.y < 0)
                {
                    SetEngineFlame(1f, 0.3f, 1f);
                }
                else if (_input.MoveVector.y > 0)
                {
                    SetEngineFlame(1f, 1f, 1f);
                }
                else if (_input.MoveVector.y > -0.1f && _input.MoveVector.y < 0.1f)
                {
                    SetEngineFlame( 0.5f, 0.5f, 1f);
                }
            }
        }
        

        private void SetEngineFlame(float x, float y, float z)
        {
            _engineFlame.transform.localScale = new Vector3(x, y, z);
        }

     
    }
}
