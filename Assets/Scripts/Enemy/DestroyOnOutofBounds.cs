using System;
using UnityEngine;

namespace Enemy
{
    public class DestroyOnOutofBounds : MonoBehaviour
    {
        public bool NoLongerVisible = false;
        private void OnBecameVisible()
        {
            NoLongerVisible = false;
        }

        private void OnBecameInvisible()
        {
            NoLongerVisible = true;
        }
        
        
    }
}
