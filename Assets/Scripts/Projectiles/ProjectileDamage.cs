using Managers;
using Player;
using UnityEngine;

namespace Projectiles
{
    public class ProjectileDamage : MonoBehaviour
    {

        public string target = null;
        private void OnCollisionEnter2D(Collision2D other)
        {

            if (other.gameObject.GetComponent<HealthManager>() != null) return;
        /*
            Destroy(other.gameObject);
            Destroy(gameObject);
        */
        
        }
    }
}
