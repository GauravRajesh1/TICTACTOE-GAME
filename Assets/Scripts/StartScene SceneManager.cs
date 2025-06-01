using UnityEngine;
using UnityEngine.UI;

public class StartSceneSceneManager : MonoBehaviour
{
    [SerializeField] Button PlayGame; // Array of button components
    [SerializeField] Button ExitGame;


    void Start()
    {
        PlayGame.interactable = true;
        ExitGame.interactable = true;
       // PlayGame.onClick.AddListener(MovenextScene); // Add listener to the PlayGame button
    }

   public void MovenextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public void ExitGameScene()
    {
        Application.Quit(); // Exit the game
    }
}
