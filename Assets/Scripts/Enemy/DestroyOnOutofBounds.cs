using System;
using UnityEngine;

namespace Enemy
{
    public class DestroyOnOutOfBounds : MonoBehaviour
    {
        public bool noLongerVisible = false;

        public bool visible = false;
        private void OnBecameVisible()
        {
            visible = true;
        }

        private void OnBecameInvisible()
        {
            if (visible)
            {
                
                gameObject.SetActive(false);
            }
        }
        
        
        
    }
}
