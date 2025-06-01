using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{

    [SerializeField] int whoTurn; // 0 for player X, 1 for player O



    public SceneManager sceneManager; // Reference to the SceneManager script

    public int turnCount; // Count of turns taken

    public GameObject[] turnIcons; // Array of button GameObjects

    public Sprite[] playIcons; // 0 = "X", 1 = "O"

    public Button[] TicTacToeSpaces; // Array of button components

    public int[] markedSpaces; // Array to keep track of marked spaces (not used in this code, but can be useful for future logic)

    public static int ScoreCardX = 0; // Score for player X

    public TextMeshProUGUI ScoreCardXText; // UI Text to display player X's score

    public static int ScoreCardO = 0; // Score for player O

    public TextMeshProUGUI ScoreCardOText; // UI Text to display player O's score

    public int check;
    void Start()
    {
        GameStartSetup();
        ScoreCardXText.text = (ScoreCardX).ToString(); // Increment player X's score and update the UI text
        ScoreCardOText.text = (ScoreCardO).ToString(); // Increment player O's score and update the UI text


    }

    void GameStartSetup()
    {
        whoTurn = 0;
        turnCount = 0;

        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);

        for (int i = 0; i < TicTacToeSpaces.Length; i++)
        {
            TicTacToeSpaces[i].interactable = true; // Enable all buttons
            TicTacToeSpaces[i].GetComponent<Image>().sprite = null; // Clear the button images
        }

        for(int i = 0; i < markedSpaces.Length; i++)
        {
            markedSpaces[i] = -100; // Initialize marked spaces to -100 (not marked)
        }
    }

    public void Playerturn(int WhichNumber)
    {
        TicTacToeSpaces[WhichNumber].GetComponent<Image>().sprite = playIcons[whoTurn];
        TicTacToeSpaces[WhichNumber].interactable = false; // Disable the button after clicking

        markedSpaces[WhichNumber] = whoTurn + 1; // Mark the space with the current player's number

        turnCount += 1; // Increment the turn count

        if (turnCount > 4)
        {
           if( WinnerCheck() ) // Check for a winner after the 4th turn
           {
                if(whoTurn == 0) // If player X wins
                {
                    ScoreCardX++; // Increment player X's score and update the UI text
                }
                else // If player O wins
                {
                    ScoreCardO++; // Increment player O's score and update the UI text
                }
                check = 1;
                sceneManager.HandleScene(whoTurn);  // Call the method to change to the winner Scene
           }

        }

        if (whoTurn == 0)
        {
                whoTurn = 1; // Switch to player O
                turnIcons[0].SetActive(false);
                turnIcons[1].SetActive(true);
            
           
            
        }
        else
        {
            whoTurn = 0; // Switch to player X
            turnIcons[0].SetActive(true);
            turnIcons[1].SetActive(false);
        }

        if(turnCount == 9 && check == 0)
        {
            sceneManager.HandleScene(2);
        }

       

    }

   private bool WinnerCheck()
    {
        int s1 = markedSpaces[0] + markedSpaces[1] + markedSpaces[2];
        int s2 = markedSpaces[3] + markedSpaces[4] + markedSpaces[5];
        int s3 = markedSpaces[6] + markedSpaces[7] + markedSpaces[8];
        int s4 = markedSpaces[0] + markedSpaces[3] + markedSpaces[6];
        int s5 = markedSpaces[1] + markedSpaces[4] + markedSpaces[7];
        int s6 = markedSpaces[2] + markedSpaces[5] + markedSpaces[8];
        int s7 = markedSpaces[0] + markedSpaces[4] + markedSpaces[8];
        int s8 = markedSpaces[2] + markedSpaces[4] + markedSpaces[6];

        var Solutions = new int[] { s1, s2, s3, s4, s5, s6, s7, s8 };

        for(int i = 0; i < Solutions.Length; i++)
        {
            if (Solutions[i] == 3*(whoTurn + 1))
            {
                return true; // Exit the method after finding a winner
            }
        }
        return false;
    }
}
