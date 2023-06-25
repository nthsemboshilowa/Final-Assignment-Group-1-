using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Player : MonoBehaviour
{
    // The player's name
    public string Name;

    // The player's current collection of destination cards.
    public List<DestinationCard> DestinationCards = new List<DestinationCard>();

    // The routes the player wants to claim at any given time.
    public List<BoardRoute> TargetedRoutes = new List<BoardRoute>();

    // All the cities this Player has already connected.
    public List<City> ConnectedCities = new List<City>();

    // The player's color (e.g. red, blue, black, green, or yellow)
    public PlayerColour.Colour Colour;

    // The Player's current collection of train cards.
    public List<TrainCard> Hand = new List<TrainCard>();

    // When one player has 2 or less train cars the remaining, the final turn begins.
    public int RemainingTrainCars = 48;

    // The train card colors this Player wants to draw.
    public List<TrainColor> DesiredColors = new List<TrainColor>();

    // A reference to the game board
    public Board Board { get; set; }

    public Player(string name, PlayerColour.Colour colour, Board board)
    {
        Name = name;
        DestinationCards = board.DestinationCards.Pop(3).ToList();
        Colour = colour;
        Board = board;

        // CalculateTargetedRoutes();
    }


}
