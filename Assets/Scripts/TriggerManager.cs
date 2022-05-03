using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{

    public int feedAmount = 1;
    public int damageAmount = 1;
    private GameManager gameManager;

    private void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bone")
        {
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(feedAmount);
            Destroy(other.gameObject);
        }
        if (gameObject.tag == "Player")
        {
            gameManager.DescreaseLife(damageAmount);
        }
    }
}
