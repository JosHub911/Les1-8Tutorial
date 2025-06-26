using UnityEngine;

public class PlayerMove1 : MonoBehaviour
{
    public float moveSpeed = 5f; // Beweegingssnelheid, instelbaar via de Inspector

    void Update()
    {
        // Lees input van toetsenbord (WASD of pijltjestoetsen)
        float moveX = Input.GetAxis("Horizontal"); // Links/Rechts (A/D of pijltjes)
        float moveZ = Input.GetAxis("Vertical");   // Vooruit/Achteruit (W/S of pijltjes)

        // Combineer beweging tot een vector
        Vector3 move = new Vector3(moveX, 0f, moveZ);

        // Verplaats de speler
        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
    }
}
