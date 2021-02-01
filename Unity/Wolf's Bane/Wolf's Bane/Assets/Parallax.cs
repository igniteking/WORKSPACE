using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject cam;
    public float ParallaxEffect;

    void Start() {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    void Update()
    {
        float dist = (cam.transform.position.x * ParallaxEffect);
        transform.position = new Vector3(startpos = dist, transform.position.y, transform.position.z);
    }
}
