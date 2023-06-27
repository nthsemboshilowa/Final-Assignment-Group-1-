using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerSwitch : MonoBehaviour
{
    public Text playerTag1;
    public Text playerTag2;
    public InputField display1;
    public InputField display2;


    private void Start()
    {

        playerTag1.text = PlayerPrefs.GetString("Player1Tag");
        playerTag2.text = PlayerPrefs.GetString("Player2Tag");
        display1.text = PlayerPrefs.GetString("Player1Tag");
        display2.text = PlayerPrefs.GetString("Player2Tag");


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


}
