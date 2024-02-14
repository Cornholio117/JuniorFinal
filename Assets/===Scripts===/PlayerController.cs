using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticallInput;
    private float xRange = 21.5f;
    private float xRangeNegative = -5.5f;
    private float yRange = 10.5f;
    private float yRangeNegative = -4.5f;

    public float speed = 20.0f;

    public GameObject projectilePrefab;
    public Transform firingPosition;
    public AudioSource shootAudio;

    public bool gameOver = false;

    void Update()
    {
        PlayerControls();
    }
    void PlayerControls()
    {
        // Check for left and right bounds
        if (transform.position.x < xRangeNegative)
        {
            transform.position = new Vector3(xRangeNegative, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Check for up and down bounds
        if (transform.position.y < yRangeNegative)
        {
            transform.position = new Vector3(transform.position.x, yRangeNegative, transform.position.z);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);


        // Player movement up and down
        verticallInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticallInput);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, firingPosition.position, projectilePrefab.transform.rotation);
        }
    }
}
