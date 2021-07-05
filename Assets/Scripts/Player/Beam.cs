using Unity.Mathematics;
using UnityEngine;

namespace Player
{
    public class Beam : Shoot
    {
        private void Start()
        {
            input = GetComponent<Input>();
        }

        private void Update()
        {
            if (!input.Shoot) return;
            
            var clone = Instantiate(bullet, gunPoint.position, quaternion.identity);
            clone.GetComponent<SpriteRenderer>().sprite = bulletGraphics;

        }
    }
}