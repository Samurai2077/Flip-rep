using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] float speed = 6f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));    
    }
}
