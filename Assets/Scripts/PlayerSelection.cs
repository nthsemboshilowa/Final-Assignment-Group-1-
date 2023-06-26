using UnityEngine;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour
{
    public Button player1Button;
    public Button player2Button;

    public PlayerTurn player1Turn;
    public PlayerTurn player2Turn;

    public InputField player1NameInputField;
    public InputField player2NameInputField;

    public InputField player1TagInputField;
    public InputField player2TagInputField;

    private void Start()
    {
        player1Button.onClick.AddListener(SelectPlayer1);
        player2Button.onClick.AddListener(SelectPlayer2);

        player1NameInputField.onValueChanged.AddListener(UpdatePlayer1Name);
        player2NameInputField.onValueChanged.AddListener(UpdatePlayer2Name);

        player1TagInputField.onValueChanged.AddListener(UpdatePlayer1Tag);
        player2TagInputField.onValueChanged.AddListener(UpdatePlayer2Tag);

    }

    public void SelectPlayer1()
    {
        player1Button.interactable = true;
        player2Button.interactable = false;

        string playerName = player1NameInputField.text;
        string playerTag = player1TagInputField.text;
        player1Turn.Name = playerName;

        player1Turn.StartPlayerTurn();
    }

    private void SelectPlayer2()
    {
        player1Button.interactable = false;
        player2Button.interactable = true;

        string playerName = player2NameInputField.text;
        string playerTag = player2TagInputField.text;
        player2Turn.Name = playerName;

        player2Turn.StartPlayerTurn();
    }

    public void StartPlayerTurn(PlayerTurn playerTurn)
    {
        // Any additional setup for the player's turn can be done here
        playerTurn.StartPlayerTurn();
    }

    private void UpdatePlayer1Name(string newName)
    {
        player1Turn.Name = newName;
    }

    private void UpdatePlayer2Name(string newName)
    {
        player2Turn.Name = newName;
    }

    private void UpdatePlayer1Tag(string newTag)
    {
        player1TagInputField.text = newTag;

        // Store the value of player1TagInputField in PlayerPrefs
        PlayerPrefs.SetString("Player1Tag", newTag);
        PlayerPrefs.Save();
    }

    private void UpdatePlayer2Tag(string newTag)
    {
        player2TagInputField.text = newTag;
    }

    private void Update()
    {
        player1TagInputField.text = player1NameInputField.text;
        player2TagInputField.text = player2NameInputField.text;
    }
}


