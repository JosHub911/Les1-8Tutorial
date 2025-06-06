using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        // Check of de speler de spatie indrukt
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Laad de "GameScene" in met de LoadScene methode
            SceneManager.LoadScene("GameScene");
        }
    }
}
