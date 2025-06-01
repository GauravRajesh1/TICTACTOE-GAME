using UnityEngine;

public class OptionsUIManager : MonoBehaviour
{
    [SerializeField] private GameObject optionsPanel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleOptionsPanel();
        }
    }

    public void ToggleOptionsPanel()
    {
       
       optionsPanel.SetActive(!optionsPanel.activeSelf);
        
    }

    public void HandleExitButton()
    {
        GameController.ScoreCardX = 0; // Reset player X's score
        GameController.ScoreCardO = 0; // Reset player O's score
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartScene");
    }

    public void HandleRestartButton()
    {
        GameController.ScoreCardX = 0; // Reset player X's score
        GameController.ScoreCardO = 0; // Reset player O's score
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
