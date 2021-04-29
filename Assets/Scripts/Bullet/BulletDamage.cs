using Player;
using UnityEngine;

namespace Bullet
{
    public class BulletDamage : MonoBehaviour
    {

        public string target = null;
        private void OnCollisionEnter2D(Collision2D other)
        {

            if (other.gameObject.GetComponent<HealthManager>() != null) return;
        
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
