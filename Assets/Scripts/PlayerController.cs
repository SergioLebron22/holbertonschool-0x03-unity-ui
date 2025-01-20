using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private int score = 0;

    public int health = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            Debug.Log($"Score: {score}");
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Trap")) {
            health--;
            Debug.Log($"Health: {health}");
        }
        if (other.CompareTag("Goal")) {
            Debug.Log("You win!");
        }
    }
}
