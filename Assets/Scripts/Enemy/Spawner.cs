using Systems;
using UnityEngine;

namespace Enemy
{
    public class Spawner : MonoBehaviour
    {

        public ObjectPooler pooler;

        public GameObject[] spawnPoints;


        public void SpawnEnemy()
        {
            pooler.GetPooleObject();
        }
        
        // TODO: Get Object from Object Pooler
        // TODO: Activate object
        // TODO: Position at random Spawnpoint

    }
}