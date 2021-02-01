using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> Content;
    private float offset = 60f;
    // Start is called before the first frame update
    void Start()
    {
        if (Content != null && Content.Count > 0)
        {
            Content = Content.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void moveContent()
    {
        GameObject moveContent = Content[0];
        Content.Remove(moveContent);
        float newZ = Content[Content.Count - 1].transform.position.z + offset;
        moveContent.transform.position = new Vector3(0, 0, newZ);
        Content.Add(moveContent);
    }
}