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
        if(other.gameObject.name.Contains("Bone")) {
            //animal hit by bone
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            //lifeManager.IncreaseScore();
            //Destroy(gameObject);
            Destroy(other.gameObject);
        } else if(other.gameObject.name.Contains("Player")) {
            //player hit by animal
            lifeManager.DescreaseLife();
        }
    }
}
