using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioSource CollisionSound;
    public ParticleSystem deadParticle;
    public GameObject player;

    // onCollisionEnter is used when using collisions in game
    void Start()
    {
        CollisionSound = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Instantiate(deadParticle, transform.position, Quaternion.identity);
            CollisionSound.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            player.SetActive(false);
        }
    }
}
