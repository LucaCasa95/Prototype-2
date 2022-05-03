using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{

    public Slider hungerSlider;
    private int amountToBeFed = 3;
    private int currentFedAmount = 0;
    private GameManager gameManager;
    private AudioSource deathSound;

    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        deathSound = GameObject.Find("DeathSound").GetComponent<AudioSource>();
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.value = currentFedAmount;
        if(currentFedAmount >= amountToBeFed)
        {
            deathSound.Play();
            gameManager.IncreaseScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
