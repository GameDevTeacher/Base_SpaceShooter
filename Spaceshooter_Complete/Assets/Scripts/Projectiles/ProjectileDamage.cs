using Systems;
using Managers;
using UnityEngine;

namespace Projectiles
{
    public class ProjectileDamage : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (transform.CompareTag($"PlayerProjectile") && other.CompareTag($"Enemy"))
            {
                ObjectPooler.ReturnToPool(other.gameObject);
                Destroy(gameObject);
            }
            else if (transform.CompareTag($"EnemyProjectile") && other.CompareTag($"Player"))
            {
                HealthManager.ReduceLives();
                Destroy(gameObject);
            }
        }
    }
}
