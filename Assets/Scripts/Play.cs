using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainBoard");
    }


}
