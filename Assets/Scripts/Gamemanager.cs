using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variabelen
    public float speed = 5f;
    public float remainingTime = 30f;
    public int score = 0;

    public Transform player;

    void Update()
    {
        // Als de tijd op is, toon "Game Over" met de score
        if (remainingTime <= 0f)
        {
            Debug.Log("Game Over! Eindscore: " + score);
            enabled = false; // Schakelt Update uit
            return;          // stopt uitvoer van de rest van de code
        }

        // Beweging (pijltjestoetsen en WASD)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;
        player.Translate(movement);

        // Trek verstreken tijd af
        remainingTime -= Time.deltaTime;

        // Toon resterende tijd (afgerond) en score
        Debug.Log("Tijd over: " + Mathf.CeilToInt(remainingTime) + " | Score: " + score);
    }

    // Zorg dat speler door coins heen kan door alleen triggercolliders te gebruiken
    private void OnTriggerEnter(Collider other)
    {
        // Check of je een coin hebt geraakt
        if (other.CompareTag("Coin"))
        {
            score += 10;
            Debug.Log("Munt gepakt! +10 punten");

            Destroy(other.gameObject);
        }
    }
}
