using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float SidewaysForce = 250f;
    public PlayerMovement movement;
    private Touch touch;
    public SpawnManager spawnManager;

    // onCollisionEnter is used when using collisions in game

    void Update()
    {
        if (rb.position.y < -0.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        transform.position = new Vector3(transform.position.x, transform.position.y,
        transform.position.z + 0.5f);
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
            transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * SidewaysForce,
            transform.position.y, transform.position.z);            
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
