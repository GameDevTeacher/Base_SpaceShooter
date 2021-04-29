using UnityEngine;

namespace Environment
{
    public class ScrollingTexture : MonoBehaviour {

        public float scrollSpeed = -0.5f;
        private Vector2 _savedOffset;
        private Renderer _renderer;

        private void Start ()
        {
            _renderer = GetComponent<Renderer>();
            _savedOffset = _renderer.material.mainTextureOffset;
        }

        private void Update() 
        {
            var x = Mathf.Repeat (Time.time * scrollSpeed, 1);
            var offset = new Vector2(x, _savedOffset.y);
            _renderer.material.mainTextureOffset = offset;
        }

        private void OnDisable()
        {
            _renderer.material.mainTextureOffset = _savedOffset;
        }
    }
}