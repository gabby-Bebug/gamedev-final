using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    //Gameover Screen for when you die
    

    //Every frame, we check for player inputs
    void Update()
    {
        //If the player hit space. . .
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Takes you back to the game
            SceneManager.LoadScene("Platforms");
        }
    }
}