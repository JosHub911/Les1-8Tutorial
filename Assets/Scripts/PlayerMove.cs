using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public ScoreManager scoreManager;

    void Start()
    {
        // Check of ScoreManager is ingesteld
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager ontbreekt!");
        }

        // Debug de ingestelde snelheid
        Debug.Log("Snelheid: " + speed);
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(move, 0f, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            scoreManager.AddScore(10);
            Debug.Log("Munt gepakt!");
            Destroy(other.gameObject);
        }
    }
}
