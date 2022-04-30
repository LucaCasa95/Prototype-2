using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    private int playerLifes = 3;
    private int score = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        PrintRemainingLifes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DescreaseLife() {
        playerLifes -= 1;
        PrintRemainingLifes();
        if(playerLifes <= 0) {
            Debug.Log("Game Over");
            Destroy(player);
        }
    }

    public void IncreaseScore() {
        score += 1;
        Debug.Log("Score = " + score);
    }

    private void PrintRemainingLifes() {
        Debug.Log("Vite rimanenti = " + playerLifes);
    }
}
