using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{

    
    public void PlayGame()
    {
        SceneManager.LoadScene("Board");
    }

    public void Player1()
    {
        SceneManager.LoadScene("Player 1");
    }
    
    public void Player2()
    {
        SceneManager.LoadScene("Player 2");
    }

}
