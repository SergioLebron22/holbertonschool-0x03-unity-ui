using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playButton != null) {
            playButton.onClick.AddListener(PlayMaze);
        }
        if (quitButton != null) {
            quitButton.onClick.AddListener(QuitMaze);
        }
    }

    public void PlayMaze() {
        SceneManager.LoadScene("maze");
    }

    public void QuitMaze() {
        Debug.Log("Quit Game");
    }
}
