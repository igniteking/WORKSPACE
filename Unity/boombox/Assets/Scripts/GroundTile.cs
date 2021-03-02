using UnityEngine;

public class GroundTile : MonoBehaviour
{
    TileManager tileManager;
    // Start is called before the first frame update
    private void Start()
    {
        tileManager = GameObject.FindObjectOfType<TileManager>();
        SpawnObsticle();
    }

    private void OnTriggerExit(Collider other)
    {
        tileManager.SpawnTile1();
        tileManager.SpawnTile2();
        Destroy(gameObject, 2);
    }
    // Update is called once per frame

    public GameObject obsticlePrefab;
    void SpawnObsticle()
    {
        int obsticleSpawnIndex = Random.Range(2, 7);
        Transform spawnPoint = transform.GetChild(obsticleSpawnIndex).transform;

        Instantiate(obsticlePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
