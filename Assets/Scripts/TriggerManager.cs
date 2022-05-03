using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bone")
        {
            Debug.Log("sono un cane, mi ha colpito un osso");
            //dog hit by bone
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            //spacco l'osso
            Destroy(other.gameObject);
        }

        if (gameObject.tag == "Player")
        {
            Debug.Log("sono il player, mi ha colpito un cane");
            //dog hit by bone
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            //spacco l'osso
            Destroy(other.gameObject);
        }
    }
}
