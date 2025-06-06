using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;
    private List<int> coins = new List<int>();

    void Start()
    {
        InitializeGame();
    }

    void Update()
    {
        CheckWinCondition();
        CheckCoinInput();
    }

    
    private void InitializeGame()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Game Start " + (i + 1));
        }
    }

   
    private void CheckCoinInput()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            int coinValue = Random.Range(10, 12);
            AddCoin(coinValue);
        }
    }

    
    private void CheckWinCondition()
    {
        if (score >= 50)
        {
            Debug.Log("Winner!");
        }
    }

    // Adds the coin to the list and updates the score
    private void AddCoin(int coinValue)
    {
        coins.Add(coinValue);
        score += coinValue;
        Debug.Log("You got a coin! Total Score: " + score);
    }
}
