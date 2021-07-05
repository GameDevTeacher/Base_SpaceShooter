using Unity.Mathematics;
using UnityEngine;

namespace Actions
{
    public class Shoot : MonoBehaviour
    {
        public Transform gunPoint;
        public GameObject bullet;
        public Sprite bulletGraphics;

        private Player.PlayerInput.Input _input;

        private void Start()
        {
            _input = GetComponent<Player.PlayerInput.Input>();
        }

        private void Update()
        {
            if (!_input.Shoot) return;
            
            var clone = Instantiate(bullet, gunPoint.position, quaternion.identity);
            clone.GetComponent<SpriteRenderer>().sprite = bulletGraphics;

        }
    }
}