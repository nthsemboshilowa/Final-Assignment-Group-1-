using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using Unity.VisualScripting;

public class Play : MonoBehaviour
{
    public GameObject playerHandDisplay;

    public Text playerTag1;
    public Text playerTag2;

    public InputField display1;
    public InputField display2;

    public bool justPlayed = true;
    public GameObject playerName1;
    public GameObject playerName2;

    private string previousScene = "";

    private void Start()
    {
        playerTag1.text = PlayerPrefs.GetString("Player1Tag");
        playerTag2.text = PlayerPrefs.GetString("Player2Tag");
        display1.text = PlayerPrefs.GetString("Player1Tag");
        display2.text = PlayerPrefs.GetString("Player2Tag");

        previousScene = PlayerPrefs.GetString("PreviousScene", "");

        if (SceneManager.GetActiveScene().name == "Player Switch")
        {
            if (previousScene == "Player 1")
            {
                playerName1.SetActive(false);
            }

        }

        if (SceneManager.GetActiveScene().name == "Player Switch")
        {

            if (previousScene == "Player 2")
            {
                playerName2.SetActive(false);
            }
        }
    }

    private void Update()
    {
        playerTag1.text = display1.text;
        playerTag2.text = display2.text;
        PlayerPrefs.SetString("Player1Tag", display1.text);
        PlayerPrefs.SetString("Player2Tag", display2.text);
        PlayerPrefs.SetString("Player1Tag", playerTag1.text);
        PlayerPrefs.SetString("Player2Tag", playerTag2.text);
        PlayerPrefs.Save();
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);
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

    public void PlayerChoice()
    {
        SceneManager.LoadScene("Player Switch");
    }

    public void Player1Done()
    {
        SceneManager.LoadScene("Player Switch");
        previousScene = "Player 1";
    }

    public void Player2Done()
    {
        SceneManager.LoadScene("Player Switch");
        previousScene = "Player 2";
    }

    public void Destroy()
    {
        Destroy(playerHandDisplay);
    }
}

