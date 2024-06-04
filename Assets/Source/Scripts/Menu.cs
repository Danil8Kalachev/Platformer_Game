using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public const int _numberScene = 1;

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;

    private void OnEnable()
    {
        _startButton?.onClick.AddListener(OnStartGame);
        _exitButton?.onClick.AddListener(OnExitGame);
    }

    private void OnDisable()
    {
        _startButton?.onClick.RemoveListener(OnStartGame);
        _exitButton?.onClick.RemoveListener(OnExitGame);
    }

    private void OnStartGame() => SceneManager.LoadScene(_numberScene);

    private void OnExitGame() => Application.Quit();
}