using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Zorg voor een variabele met je startscore
    public int score = 0;

    // Maak een methode AddScore die vanaf een ander script aangeroepen kan worden
    // en waaraan je de gescoorde punten mee kunt geven als argument
    public void AddScore(int points)
    {
        // Tel de punten op bij de score
        score += points;

        // Stuur bericht naar de console dat je een munt hebt gepakt!
        Debug.Log("Munt gepakt! Score: " + score);
    }
}
