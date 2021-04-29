using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class InputAdvanced : MonoBehaviour
    {
        public enum InputType
        {
            Keyboard,
            Gamepad
        }
        
        public InputType inputType;
        
        [HideInInspector] public Vector2 MoveVector => _moveVector;
        private Vector2 _moveVector;
        
        private void Update()
        {
            switch (inputType)
            {
                case InputType.Keyboard:
                    _moveVector.x = (Keyboard.current.aKey.isPressed ? -1f : 0f) + (Keyboard.current.dKey.isPressed ? 1f : 0f);
                    _moveVector.y = (Keyboard.current.sKey.isPressed ? -1f : 0f) + (Keyboard.current.wKey.isPressed ? 1f : 0f);
                    break;
                    
                case InputType.Gamepad when Gamepad.current == null:
                    return;
                    
                case InputType.Gamepad:
                    _moveVector.x = (Gamepad.current.dpad.left.isPressed ? -1f : 0f) + (Gamepad.current.dpad.right.isPressed ? 1f : 0f);
                    _moveVector.y = (Gamepad.current.dpad.down.isPressed ? -1f : 0f) + (Gamepad.current.dpad.up.isPressed ? 1f : 0f);
                    break;
                    
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}