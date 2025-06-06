using UnityEngine;

public class CoinSpawnerPlayer : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5.0f;
    [SerializeField] private GameObject coinTemplate;

    private void Awake()
    {
        SpawnCoinAtRandomPosition();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = Vector3.right * horizontalInput * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void SpawnCoinAtRandomPosition()
    {
        float randomX = Random.Range(-10f, 10f);
        Vector3 spawnLocation = new Vector3(randomX, 0f, 0f);
        Instantiate(coinTemplate, spawnLocation, Quaternion.identity);
    }
}
