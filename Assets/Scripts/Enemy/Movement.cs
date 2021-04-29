using UnityEngine;

namespace Enemy
{
    public class Movement : MonoBehaviour
    {
    
        private float enemySpeed;
        

        void Update()
        {
            transform.Translate(Vector3.down * enemySpeed);
        }
    }
}