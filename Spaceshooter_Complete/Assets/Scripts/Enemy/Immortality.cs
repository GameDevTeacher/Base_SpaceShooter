using System;
using UnityEngine;

namespace Enemy
{
    public class Immortality : MonoBehaviour
    {
        public float immortalityWindow = 2f;
        [HideInInspector] public bool canTakeDamage = false;

        private float timer = -1f;

        private void OnBecameVisible()
        {
            timer = immortalityWindow;
        }

        private void Update()
        {
            if (timer <= -0.1f) return;
            timer -= 1 * Time.deltaTime;

            if (timer <= 0)
            {
                canTakeDamage = true;
            }
        }
    }
}
