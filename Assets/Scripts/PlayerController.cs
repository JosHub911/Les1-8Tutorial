using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //  speed variabele die veraderbaar is in de inspector
    public float speed = 5f;

    // variabele 
    public GameObject coinPrefab;

    void Start()
    {
        // random waarde tussen -10 en 10 voor het plaatsen van een munt op de x-as
        float randomX = Random.Range(-10f, 10f);

        //  Instantiate methode om de coinPrefab op een random x-positie in de scene te zetten
        Vector3 spawnPosition = new Vector3(randomX, 0f, 0f);
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }

    void Update()
    {
        //  de speler met pijltjestoetsen links/rechts of A/D
        float horizontalInput = Input.GetAxis("Horizontal");

        //  verplaatsing gebaseerd op de input, snelheid en framerate
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;

        // de verplaatsing toe
        transform.Translate(movement);
    }
}
