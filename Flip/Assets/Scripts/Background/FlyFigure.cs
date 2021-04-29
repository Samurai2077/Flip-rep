using UnityEngine;

public class FlyFigure : MonoBehaviour
{
    public SpawnerFlyFigure spawner = null;
    public float speedRotate = 36f;
    public float scale;
    public float time;
    public float speed;

    public void Start()
    {
        scale = Random.Range(0.1f, 1f);
        time = Time.time;
        speed = Random.Range(3f, 6f);

        speedRotate = Random.Range(-50f, 50f);
        transform.localScale = new Vector3(0.01f, 0.01f, 1);
        Invoke("Destroy", speed * 3.14f);
    }

    public void Update()
    {
        transform.Rotate(new Vector3(0, 0, speedRotate * Time.deltaTime));
        Vector3 scaleV = new Vector3(Mathf.Sin((Time.time - time) / speed) * scale, Mathf.Sin((Time.time - time) / speed) * scale, 1);
        transform.localScale = scaleV;
    }

    public void Destroy()
    {
        spawner.Spawn();
        Destroy(gameObject);
    }
}
