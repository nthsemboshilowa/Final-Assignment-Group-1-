using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

public class PlayerTurn : MonoBehaviour
{
    public Button drawTrainCardsButton;
    public Button claimRouteButton;
    public Button drawDestinationTicketsButton;

    public string Name;
    public List<DestinationCard> DestinationCards = new List<DestinationCard>();
    public List<BoardRoute> TargetedRoutes = new List<BoardRoute>();
    public List<City> ConnectedCities = new List<City>();
    public PlayerColour.Colour Colour;
    public List<TrainCard> Hand = new List<TrainCard>();
    public int RemainingTrainCars = 48;
    public List<TrainColor> DesiredColors = new List<TrainColor>();
    public Board Board;

    private bool isPlayerTurn = false;

    private void Start()
    {
        drawTrainCardsButton.onClick.AddListener(DrawTrainCards);
        claimRouteButton.onClick.AddListener(ClaimRoute);
        drawDestinationTicketsButton.onClick.AddListener(DrawDestinationTickets);
    }

    private void Update()
    {
        if (isPlayerTurn)
        {
            // Check if the player has made a decision or the turn has ended
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                EndPlayerTurn();

            }
        }
    }

    private void DrawTrainCards()
    {
        // Check if the player has already drawn 2 train cards
        if (Hand.Count >= 2)
        {
            Debug.Log("You have already drawn 2 train cards in this turn.");
            return;
        }

        // Logic for drawing train cards goes here
        Debug.Log("Drawing train cards");

        // Simulate drawing 2 train cards
        for (int i = 0; i < 2; i++)
        {
            // Replace the logic below with your actual implementation of drawing train cards
            // For now, we'll simply add a dummy train card to the player's hand
            TrainCard card = new TrainCard();
            Hand.Add(card);
        }

        EndPlayerTurn();
    }

    private void ClaimRoute()
    {
        // Logic for claiming a route goes here
        Debug.Log("Claiming a route");

        EndPlayerTurn();
    }

    private void DrawDestinationTickets()
    {
        // Logic for drawing destination tickets goes here
        Debug.Log("Drawing destination tickets");

        // Call the DrawTicket method of the DestinationTicketDeck
        DestinationTicketDeck ticketDeck = FindObjectOfType<DestinationTicketDeck>();
        if (ticketDeck != null)
        {
            ticketDeck.DrawTicket();
        }
    }

    public void StartPlayerTurn()
    {
        isPlayerTurn = true;
        // Any additional setup for the player's turn can be done here
        Debug.Log("Player's turn has started");
    }

    public void EndPlayerTurn()
    {
        isPlayerTurn = false;
        // Reset any necessary variables or perform end-of-turn tasks here
        Debug.Log("Player's turn has ended");
        SceneManager.LoadScene("Player Switch");


    }
}

