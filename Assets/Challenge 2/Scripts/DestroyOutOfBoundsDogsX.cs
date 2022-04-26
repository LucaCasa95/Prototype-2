using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsDogsX : MonoBehaviour
{
    private float leftLimit = -30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x <= leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
