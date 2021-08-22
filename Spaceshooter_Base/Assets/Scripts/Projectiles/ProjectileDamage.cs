using Systems;
using Enemy;
using Managers;
using TMPro;
using UnityEngine;

namespace Projectiles
{
    public class ProjectileDamage : MonoBehaviour
    {
        //[SerializeField] private string PlayerProjectile, EnemyProjectile, Player, Enemy;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (transform.CompareTag($"PlayerProjectile") && other.CompareTag($"Enemy"))
            {
                if (other.TryGetComponent(out Immortality immortality))
                {
                    if (immortality.canTakeDamage == false) return;
                }
                
                ObjectPooler.ReturnToPool(other.gameObject);
                
                ScoreManager.AddScore();

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