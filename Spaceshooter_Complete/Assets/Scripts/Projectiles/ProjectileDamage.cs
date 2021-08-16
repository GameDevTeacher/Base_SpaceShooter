using Systems;
using Enemy;
using Managers;
using TMPro;
using UnityEngine;

namespace Projectiles
{
    public class ProjectileDamage : MonoBehaviour
    {

        [SerializeField] private string PlayerProjectile, EnemyProjectile, Player, Enemy;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (transform.CompareTag($"PlayerProjectile") && other.CompareTag($"Enemy"))
            {
                if (other.GetComponent<Immortality>().canTakeDamage == false) return;
                
                ObjectPooler.ReturnToPool(other.gameObject);
                
                ScoreManager.AddScore();
                // TODO: Fix the Double Damage
                
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
