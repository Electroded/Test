using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _loseScreen;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject _startButton;

    private void Start()
    {
        _loseScreen.SetActive(false);

        _winScreen.SetActive(false);

        _startButton.SetActive(false);
    }

    public void LoseScreen()
    {
        _loseScreen.SetActive(true);

        _startButton.SetActive(true);
    }

    public void WinScreen()
    {
        _winScreen.SetActive(true);

        _startButton.SetActive(true);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
