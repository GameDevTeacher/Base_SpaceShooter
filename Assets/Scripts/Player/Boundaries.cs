using UnityEngine;

namespace Player
{
    public class Boundaries : MonoBehaviour
    {
        public Camera MainCamera;
        private Vector2 screenBounds;
        private float objectWidth;
        private float objectHeight;

        // Use this for initialization
        private void Start () {
            screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
            objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
            objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
        }

        // Update is called once per frame
        private void LateUpdate(){
            var viewPos = transform.position;
            viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
            viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
            transform.position = viewPos;
        }
    }
}
    /*
     
     
    private Vector2 _screenBounds;
    private float _objectWidth, _objectHeight;

    private void Start()
    {
        if (Camera.main is { })
            _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        _objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        _objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }
    
    private void LateUpdate()
    {
        var viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, _screenBounds.x + _objectWidth, _screenBounds.x * -1 - _objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, _screenBounds.y + _objectHeight, _screenBounds.y * -1 - _objectHeight);
        transform.position = viewPos;
    }
}
*/