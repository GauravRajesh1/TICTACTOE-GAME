using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class SceneManager : MonoBehaviour
{
    [SerializeField] string sceneName;
    public static int holdvalue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created  
   public void HandleScene(int whoTurn)
    {
        Debug.Log(whoTurn);
        holdvalue = whoTurn; // Store the current player's turn in a static variable
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
       
    }
}
