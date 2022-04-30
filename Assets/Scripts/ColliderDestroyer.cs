using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDestroyer : MonoBehaviour
{
    LifeManager lifeManager;

    // Start is called before the first frame update
    void Start()
    {
       lifeManager = GameObject.Find("LifeManager").GetComponent<LifeManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("io sono " + gameObject.name + " e mi ha toccato " + other.gameObject.name);
        if(other.gameObject.name.Contains("Bone")) {
            lifeManager.IncreaseScore();
            Destroy(gameObject);
            Destroy(other.gameObject);
        } else if(other.gameObject.name.Contains("Player")) {
            lifeManager.DescreaseLife();
        }
    }
}
