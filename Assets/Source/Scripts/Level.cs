using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] private int _numberScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMovement playerMovement))
            SceneManager.LoadScene(_numberScene);
    }
}