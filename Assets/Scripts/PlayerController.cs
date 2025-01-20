using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private int score = 0;
    public int health = 5;
    public Text scoreText;
    public Text healthText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetScoreText();
        SetHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;

        transform.Translate(movement, Space.World);

        if (health == 0) {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Pickup")) {
            score++;
            SetScoreText();
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Trap")) {
            health--;
            SetHealthText();
        }
        if (other.CompareTag("Goal")) {
            Debug.Log("You win!");
        }
    }

    void SetScoreText() {
        scoreText.text = $"Score: {score}";
    }

    void SetHealthText() {
        healthText.text = $"Health: {health}";
    }
}
