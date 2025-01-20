using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playButton != null) {
            playButton.onClick.AddListener(PlayMaze);
        }
        else
        {
            Debug.LogError("Play Button not assigned in the Inspector!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMaze() {
        SceneManager.LoadScene("maze");
    }
}
