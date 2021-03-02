using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject groundTile1;
    public GameObject groundTile2;
    Vector3 nextSpawnPoint;

    public void SpawnTile1 ()
    {
       GameObject temp = Instantiate(groundTile1, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile1();
            SpawnTile2();        }
    }
    public void SpawnTile2()
    {
        GameObject temp = Instantiate(groundTile2, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
}
