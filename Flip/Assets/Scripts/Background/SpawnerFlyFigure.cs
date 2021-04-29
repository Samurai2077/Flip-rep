using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFlyFigure : MonoBehaviour
{
    [SerializeField] FlyFigure[] prefabs = null;

    public void Start()
    {
        Spawn(300);
    }

    public void Update()
    {
        transform.Rotate(0, 0, 5f * Time.deltaTime);
    }

    public void Spawn(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        FlyFigure fly = Instantiate(prefabs[Random.Range(0, prefabs.Length)], Random.insideUnitCircle * 9f, Quaternion.identity);
        fly.transform.SetParent(transform);
        fly.spawner = this;
    }
}
