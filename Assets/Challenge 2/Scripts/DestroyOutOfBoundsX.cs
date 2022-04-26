using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }

    }
}
