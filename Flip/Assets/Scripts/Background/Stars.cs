using UnityEngine;

public class Stars : MonoBehaviour
{
    private void Start()
    {
        float fieldSize = LevelSettings.FieldSize + 1;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-50f * fieldSize, 50f * fieldSize),
            Random.Range(25f * fieldSize, 150f * fieldSize)));
        Invoke("Destroy", 10f);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }    
}
