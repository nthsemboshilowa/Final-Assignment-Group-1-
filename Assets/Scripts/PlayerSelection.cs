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

    private void Start()
    {
        player1Button.onClick.AddListener(SelectPlayer1);
        player2Button.onClick.AddListener(SelectPlayer2);

        player1NameInputField.onValueChanged.AddListener(UpdatePlayer1Name);
        player2NameInputField.onValueChanged.AddListener(UpdatePlayer2Name);
    }

    public void SelectPlayer1()
    {
        player1Button.interactable = true;
        player2Button.interactable = false;

        string playerName = player1NameInputField.text;
        player1Turn.Name = playerName;

        player1Turn.StartPlayerTurn();
    }

    private void SelectPlayer2()
    {
        player1Button.interactable = false;
        player2Button.interactable = true;

        string playerName = player2NameInputField.text;
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
}

