using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.PlayerInput
{
    public class Input : MonoBehaviour
    {
        public Vector2 MoveVector => _moveVector;
        private Vector2 _moveVector;

        public bool Shoot { get; private set; }

        // Update is called once per frame
        private void Update()
        {
            _moveVector.x = (Keyboard.current.aKey.isPressed ? -1f : 0f) + (Keyboard.current.dKey.isPressed ? 1f : 0f);
            _moveVector.y = (Keyboard.current.sKey.isPressed ? -1f : 0f) + (Keyboard.current.wKey.isPressed ? 1f : 0f);

            Shoot = Keyboard.current.spaceKey.wasPressedThisFrame;
        }
    }
}