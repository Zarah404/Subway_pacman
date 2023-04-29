using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public float playerPositionZ = 50f; // The required Z position of the player
    public float restartDelay = 1f; // The amount of time to wait before restarting the game

    private GameObject player;
    private bool gameEnded = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        // Check if the player is below the required Z position
        if (!gameEnded && player.transform.position.z < playerPositionZ)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameEnded = true;
        Invoke("RestartGame", restartDelay);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
