using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;
    public Transform respawnPoint; // Assign an empty GameObject in the Inspector
    private Vector3 initialPosition;

    void Start()
    {
        // Fallback: use starting position if no respawn point is assigned
        initialPosition = transform.position;
    }

    public void TakeDamage()
    {
        lives--;

        if (lives > 0)
        {
            Respawn();
        }
        else
        {
            GameOver();
        }
    }

    void Respawn()
    {
        // Move the player to the respawn point
        if (respawnPoint != null)
            transform.position = respawnPoint.position;
        else
            transform.position = initialPosition;

        // Reset physical velocity if using Rigidbody
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        // You could reload the scene here using SceneManager.LoadScene
    }
}
