using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 0.005f;
    private void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}