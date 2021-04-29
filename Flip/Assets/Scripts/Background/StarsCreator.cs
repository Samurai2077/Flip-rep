using UnityEngine;

public class StarsCreator : MonoBehaviour
{
    [SerializeField] GameObject prefab = null;

    public void Spawn()
    {
        for(int i = 0; i < 25 * (LevelSettings.FieldSize + 1); i++)
        {
            Vector3 position = new Vector3(0, -Camera.main.orthographicSize, -9);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
