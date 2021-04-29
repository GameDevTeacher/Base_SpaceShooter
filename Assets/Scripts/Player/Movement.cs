using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        private Input _input;
        // This Variable is invisible in the Inspector and is only ACCESSIBLE in this Script;
        // It is of type Input, which means it can only hold a Input Component
            // The Input Component is a custom made script.
        
        [SerializeField] private float moveSpeed;
            // This Variable is visible in the Inspector and is only ACCESSIBLE in this Script.
            // It is of type Float (decimal numbers).
            
        private Rigidbody2D _rigidbody2D;
            // This Variable is invisible in the Inspector and is only ACCESSIBLE in this Script;
            // It is of type RigidBody2D, which means it can only hold a RigidBody2D Component
            
       
        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _input = GetComponent<Input>();
        }
        // This function is CALLED at the moment a object is created in the scene
            // In this function we GET the RigidBody2D Component and ASSIGN it to a variable
            
        private void FixedUpdate()
        {
            _rigidbody2D.velocity = _input.MoveVector * moveSpeed;
        }
        // This function is CALLED 50 times per second
            // In it we update our physics velocity with the value of our input
            // and multiply it with a set speed
    }
}