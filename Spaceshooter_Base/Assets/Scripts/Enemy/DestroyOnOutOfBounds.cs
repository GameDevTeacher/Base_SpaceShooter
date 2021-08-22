using System;
using Systems;
using UnityEngine;

namespace Enemy
{
    public class DestroyOnOutOfBounds : MonoBehaviour
    {
        private void Update()
        {
            if (transform.position.y < -10f)
                ObjectPooler.ReturnToPool(gameObject);
        }
    }
}
