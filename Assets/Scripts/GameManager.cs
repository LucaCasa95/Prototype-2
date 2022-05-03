using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerLifes = 3;
    private int score = 0;
    public GameObject player;
    public Slider lifeSlider;

    // Start is called before the first frame update
    void Start()
    {
        PrintRemainingLifes();
        lifeSlider.maxValue = playerLifes;
        lifeSlider.value = playerLifes;
    }

    public void DescreaseLife(int amount) {
        playerLifes -= amount;
        lifeSlider.value = playerLifes;
        PrintRemainingLifes();
        if(playerLifes <= 0) {
            Debug.Log("Game Over.. your final score is: " + score);
            Destroy(player);
        }
    }

    public int getPlayerLife() {
        return playerLifes;
    }

    public void IncreaseScore(int points) {
        score += points;
        Debug.Log("Score = " + score);
    }

    private void PrintRemainingLifes() {
        Debug.Log("Vite rimanenti = " + playerLifes);
    }
}
