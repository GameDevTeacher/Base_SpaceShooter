using Systems;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Enemy
{
    public class Spawner : MonoBehaviour
    {
        public ObjectPooler pooler;

        public GameObject[] spawnPoints;

        public float spawnTime;
        public float spawnBuffer;
        public void Start()
        {
            InvokeRepeating(nameof(SpawnEnemy), spawnBuffer, spawnTime);
        }

        public void SpawnEnemy()
        {
           var obj = pooler.GetPooleObject();
           
           obj.SetActive(true);
           obj.transform.position =
               spawnPoints[RandomSpawn()].transform.position;
        }

        private int RandomSpawn()
        {
            return Random.Range(0, spawnPoints.Length);
        }
    }
}
