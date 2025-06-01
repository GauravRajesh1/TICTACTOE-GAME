using TMPro;
using UnityEngine;

public class WinnerSceneSceneManager : MonoBehaviour
{
    private float timer = 3f; // Timer to track the time since the scene was loaded

    [SerializeField] TextMeshProUGUI countdownText; // Reference to the TextMeshProUGUI component for displaying the countdown

    // Update is called once per frame
    void Update()
    {
        countdownText.text = Mathf.Ceil(timer).ToString(); // Update the countdown text with the remaining time

        timer -= Time.deltaTime;// Timer logic can be added here if needed

        if (timer <= 0f)
        {
            // Load the main menu scene after 3 seconds
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        }
    }
}
