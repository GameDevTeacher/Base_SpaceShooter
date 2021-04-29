using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Systems
{
    public class ObjectPooler : MonoBehaviour
    {
        private static ObjectPooler _objectPooler;
    
        [SerializeField] private GameObject pooledObject = null;
        [SerializeField] private int pooledAmount = 10;
        [SerializeField] private bool willGrow = true;

        [SerializeField] private List<GameObject> pooledObjects;

        private void Awake() => _objectPooler = this; 

        private void Start()
        {
            pooledObjects = new List<GameObject>();
        
            for (var i = 0; i < pooledAmount; i++)
            {
                var obj = (GameObject)Instantiate(pooledObject);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }

        public GameObject GetPooleObject()
        {
           /* for (int i = 0; i < pooledObjects.Count; i++)
            {
                if (!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            }

            
            foreach (var t in pooledObjects)
            {
                if (!t.activeInHierarchy)
                {
                    return t;
                }
            }*/

            foreach (var t in pooledObjects.Where(t => !t.activeInHierarchy))
            {
                return t;
            }
        
            if (!willGrow) return null;
        
            var obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
        
            return obj;
        }
    }
}
