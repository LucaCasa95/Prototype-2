using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireRate = 1f;
    private float nextFire = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog, delay by 0.5f between frames - that's the time.time part.
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
