using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMovement playerMovement))
        {
            Destroy(playerMovement.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}