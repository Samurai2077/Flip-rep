using UnityEngine;

public class Fabrica<T> : ScriptableObject
{
    [SerializeField] private T[] items = null;

    public T GetRandom() => Get(Random.Range(0, items.Length));
    public T Get(int index) => items[index];
}
