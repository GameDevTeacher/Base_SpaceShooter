using UnityEngine;

namespace Bullet
{
    public class BulletMove : MonoBehaviour
    {
        public float bulletSpeed = 0.05f;
        
        private void Update()
        {
            transform.Translate(Vector3.up * bulletSpeed);
        }
    }
}
