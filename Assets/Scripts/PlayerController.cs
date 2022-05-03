using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticallInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    public float zRange = 15.0f;
    public float bulletOffset = 1f;
    private float zero = 0f;

    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticallInput = Input.GetAxis("Vertical");

        //movement
        transform.Translate(new Vector3(horizontalInput, zero, verticallInput) * speed * Time.deltaTime);

        //out of bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.z < zero)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zero);
        }
        else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + bulletOffset), bulletPrefab.transform.rotation);
        }
    }
}
