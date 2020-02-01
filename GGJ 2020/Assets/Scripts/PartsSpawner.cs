using UnityEngine;

public class PartsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] parts; //List of parts to spawn
    [SerializeField] private GameObject terrain; //Ground (Area to drop parts in)
    private MeshCollider terrainCollider;
    [SerializeField] private float minSpawnTime = 1f;
    [SerializeField] private float maxSpawnTime = 10f;
    [SerializeField] private float spawnHeight = 1.0f; //Height at which objects are spawned

    private int xRandom = 0;
    private int zRandom = 0;
    private int randObjIndex;

    void Awake()
    {
        if (terrain != null)
        {
            terrainCollider = terrain.GetComponent<MeshCollider>();
        }
    }

    void OnEnable()
    {
        if(terrain != null)
        {
            spawnPart();
        }
    }

    Vector3 GetRandomPoint()
    {        
        xRandom = (int)Random.Range(terrainCollider.bounds.min.x, terrainCollider.bounds.max.x);
        zRandom = (int)Random.Range(terrainCollider.bounds.min.z, terrainCollider.bounds.max.z);
        
        return new Vector3(xRandom, spawnHeight, zRandom);
    }

    void spawnPart()
    {
        randObjIndex = Random.Range(0, parts.Length);
        Instantiate(parts[randObjIndex], GetRandomPoint(), Quaternion.identity);
        Invoke("spawnPart", Random.Range(minSpawnTime, maxSpawnTime));
    }
}
