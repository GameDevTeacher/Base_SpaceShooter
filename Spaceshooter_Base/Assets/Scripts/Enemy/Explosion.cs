using System;
using UnityEngine;

namespace Enemy
{
    public class Explosion : MonoBehaviour
    {
        private Transform explosion;

        private void Awake()
        {
            explosion = transform.GetChild(1);
        }

        private void OnDestroy()
        {
            explosion.GetComponent<SpriteRenderer>().enabled = true;
            explosion.transform.parent = null;
        }
    }
}
