using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentSpawner : MonoBehaviour
{
    SpawnManager groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GetComponent<SpawnManager>();
    }

    public void SpawnTriggerEntered()
    {
        groundSpawner.moveContent();
    }
}
