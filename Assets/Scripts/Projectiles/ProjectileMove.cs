using UnityEngine;

namespace Projectiles
{
    public class ProjectileMove : MonoBehaviour
    {
        private void Update()
        {
            transform.Translate(Vector3.up * 0.05f);
        }
    }
}
