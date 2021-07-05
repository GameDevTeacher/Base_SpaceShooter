using UnityEngine;

namespace Projectiles
{
    public class Lifetime : MonoBehaviour
    {
        public float lifeTime = 3f;
      
        private void Start()
        {
            Destroy(gameObject, lifeTime);
        }
    }
}
