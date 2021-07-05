using Unity.Mathematics;
using UnityEngine;

namespace Player
{
    public class Shoot : MonoBehaviour
    {
        public Transform gunPoint;
        public GameObject bullet;
        public Sprite bulletGraphics;

        private Input _input;

        private void Start()
        {
            _input = GetComponent<Input>();
        }

        private void Update()
        {
            if (!_input.Shoot) return;
            
            var clone = Instantiate(bullet, gunPoint.position, quaternion.identity);
            clone.GetComponent<SpriteRenderer>().sprite = bulletGraphics;

        }
    }
}