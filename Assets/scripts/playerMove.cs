using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public float speed;
    public float lowBoundary;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        CheckBoundary();
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.velocity = movement * speed;
    }

    void CheckBoundary()
    {
        if (transform.position.y < lowBoundary)
        {
            SceneManager.LoadScene(0); // Reload the scene if the player falls below the boundary
        }
    }
}
