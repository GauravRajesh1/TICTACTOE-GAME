using UnityEngine;
using UnityEngine.UI;
using TMPro;
public  class WinnerMessageControl : MonoBehaviour
{
   public TextMeshProUGUI WinnerText; // UI Text to display the winner message


    public void controlmessage(int winner)
    {
        WinnerText.gameObject.SetActive(true); //  the winner text at the start


        if (winner == 0)
        {
            WinnerText.text = "PLAYER X HAS WON !!!";
        }
        else if (winner == 1)
        {
            WinnerText.text = "PLAYEY O HAS WON !!!";
        }
        else if (winner == 2) 
        {
            WinnerText.text = "IT'S A DRAW !!!";
        }
      


    }
}
