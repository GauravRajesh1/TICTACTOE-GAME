using UnityEngine;

public class WinnerSceneWinnerDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public WinnerMessageControl WinnerMessageControl;
    void Start()
    {
     WinnerMessageControl.controlmessage(SceneManager.holdvalue);
    }
}
