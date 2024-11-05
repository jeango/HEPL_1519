using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float timeBetweenSpawns;
    public float maxYOffset;

    void Start()
    {
        InvokeRepeating("Spawn", 0, timeBetweenSpawns);
    }
    
    void Spawn()
    {
        var yOffset = Random.Range(-maxYOffset, maxYOffset);
        Instantiate(objectToSpawn, transform.position + new Vector3(0,yOffset), Quaternion.identity);
    }
}
