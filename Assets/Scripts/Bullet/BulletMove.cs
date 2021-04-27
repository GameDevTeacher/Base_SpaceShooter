using UnityEngine;

namespace Bullet
{
    public class BulletMove : MonoBehaviour
    {
        private void Update()
        {
            transform.Translate(Vector3.up * 0.05f);
        }
    }
}
