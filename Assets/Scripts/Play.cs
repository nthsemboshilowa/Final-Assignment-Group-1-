using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{
    public Text obj_txt;
    public InputField display;

    private void Start()
    {
        obj_txt.text = PlayerPrefs.GetString("Player1Tag");
    }

    private void Create()
    {
        obj_txt.text = display.text;
        PlayerPrefs.SetString("Player1Tag", obj_txt.text);
        PlayerPrefs.Save();
    }

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
