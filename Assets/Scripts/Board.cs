using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    public BoardRouteCollection Routes = new BoardRouteCollection();

    [SerializeField]
    public List<DestinationCard> DestinationCards = new List<DestinationCard>();

    [SerializeField]
    public List<TrainCard> Deck = new List<TrainCard>();

    [SerializeField]
    public List<TrainCard> DiscardPile = new List<TrainCard>();

    [SerializeField]
    public List<TrainCard> ShownCards = new List<TrainCard>();

    private void Awake()
    {
        CreateBoardRoutes();
        CreateDestinationCards();
        CreateTrainCardDeck();
    }

    private void CreateBoardRoutes()
    {
        // Create a new BoardRoute instance
        Routes.AddRoute(BoardRoute.City.Vancouver, BoardRoute.City.Calgary, BoardRoute.TrainColour.Grey, 3);
        Routes.AddRoute(BoardRoute.City.Calgary, BoardRoute.City.Winnipeg, BoardRoute.TrainColour.White, 6);
        Routes.AddRoute(BoardRoute.City.Winnipeg, BoardRoute.City.SaultSaintMarie, BoardRoute.TrainColour.Grey, 6);
        Routes.AddRoute(BoardRoute.City.SaultSaintMarie, BoardRoute.City.Montreal, BoardRoute.TrainColour.Black, 5);
        Routes.AddRoute(BoardRoute.City.Montreal, BoardRoute.City.Boston, BoardRoute.TrainColour.Grey, 2);
        Routes.AddRoute(BoardRoute.City.Vancouver, BoardRoute.City.Seattle, BoardRoute.TrainColour.Grey, 1);
        Routes.AddRoute(BoardRoute.City.Seattle, BoardRoute.City.Calgary, BoardRoute.TrainColour.Grey, 4);
        Routes.AddRoute(BoardRoute.City.Calgary, BoardRoute.City.Helena, BoardRoute.TrainColour.Grey, 4);
        Routes.AddRoute(BoardRoute.City.Helena, BoardRoute.City.Winnipeg, BoardRoute.TrainColour.Blue, 4);
        Routes.AddRoute(BoardRoute.City.Winnipeg, BoardRoute.City.Duluth, BoardRoute.TrainColour.Black, 4);
        Routes.AddRoute(BoardRoute.City.Duluth, BoardRoute.City.SaultSaintMarie, BoardRoute.TrainColour.Grey, 3);
        Routes.AddRoute(BoardRoute.City.SaultSaintMarie, BoardRoute.City.Toronto, BoardRoute.TrainColour.Grey, 2);
        Routes.AddRoute(BoardRoute.City.Toronto, BoardRoute.City.Montreal, BoardRoute.TrainColour.Grey, 3);
        Routes.AddRoute(BoardRoute.City.Portland, BoardRoute.City.Seattle, BoardRoute.TrainColour.Grey, 1);
        Routes.AddRoute(BoardRoute.City.Seattle, BoardRoute.City.Helena, BoardRoute.TrainColour.Yellow, 6);
        Routes.AddRoute(BoardRoute.City.Helena, BoardRoute.City.Duluth, BoardRoute.TrainColour.Orange, 6);
        Routes.AddRoute(BoardRoute.City.Duluth, BoardRoute.City.Toronto, BoardRoute.TrainColour.Purple, 6);
        Routes.AddRoute(BoardRoute.City.Toronto, BoardRoute.City.Pittsburgh, BoardRoute.TrainColour.Grey, 2);
        Routes.AddRoute(BoardRoute.City.Montreal, BoardRoute.City.NewYork, BoardRoute.TrainColour.Blue, 3);
        Routes.AddRoute(BoardRoute.City.NewYork, BoardRoute.City.Boston, BoardRoute.TrainColour.Yellow, 2);
        Routes.AddRoute(BoardRoute.City.Portland, BoardRoute.City.SanFrancisco, BoardRoute.TrainColour.Green, 5);
        Routes.AddRoute(BoardRoute.City.Portland, BoardRoute.City.SaltLakeCity, BoardRoute.TrainColour.Blue, 5);
        Routes.AddRoute(BoardRoute.City.SanFrancisco, BoardRoute.City.SaltLakeCity, BoardRoute.TrainColour.Orange, 5);
        Routes.AddRoute(BoardRoute.City.SaltLakeCity, BoardRoute.City.Helena, BoardRoute.TrainColour.Purple, 3);
        Routes.AddRoute(BoardRoute.City.Helena, BoardRoute.City.Denver, BoardRoute.TrainColour.Green, 4);
        Routes.AddRoute(BoardRoute.City.SaltLakeCity, BoardRoute.City.Denver, BoardRoute.TrainColour.Red, 3);
        Routes.AddRoute(BoardRoute.City.Helena, BoardRoute.City.Omaha, BoardRoute.TrainColour.Red, 5);
        Routes.AddRoute(BoardRoute.City.Omaha, BoardRoute.City.Duluth, BoardRoute.TrainColour.Grey, 2);
        Routes.AddRoute(BoardRoute.City.Duluth, BoardRoute.City.Chicago, BoardRoute.TrainColour.Red, 4);
        Routes.AddRoute(BoardRoute.City.Omaha, BoardRoute.City.Chicago, BoardRoute.TrainColour.Blue, 4);
        Routes.AddRoute(BoardRoute.City.Chicago, BoardRoute.City.Toronto, BoardRoute.TrainColour.White, 4);
        Routes.AddRoute(BoardRoute.City.Chicago, BoardRoute.City.Pittsburgh, BoardRoute.TrainColour.Orange, 3);
        Routes.AddRoute(BoardRoute.City.Pittsburgh, BoardRoute.City.NewYork, BoardRoute.TrainColour.White, 2);
    }

    private void CreateDestinationCards()
    {
        DestinationCards.Add(new DestinationCard(DestinationCard.City.NewYork, DestinationCard.City.Atlanta, 6));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Winnipeg, DestinationCard.City.LittleRock, 11));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Boston, DestinationCard.City.Miami, 12));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.LosAngeles, DestinationCard.City.Chicago, 16));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Montreal, DestinationCard.City.Atlanta, 9));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Seattle, DestinationCard.City.LosAngeles, 9));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.KansasCity, DestinationCard.City.Houston, 5));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Chicago, DestinationCard.City.NewOrleans, 7));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Seattle, DestinationCard.City.NewYork, 22));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Portland, DestinationCard.City.Nashville, 17));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.SaultSaintMarie, DestinationCard.City.OklahomaCity, 9));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Vancouver, DestinationCard.City.SantaFe, 13));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.SanFrancisco, DestinationCard.City.Atlanta, 17));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Vancouver, DestinationCard.City.Montreal, 20));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Montreal, DestinationCard.City.NewOrleans, 13));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.LosAngeles, DestinationCard.City.NewYork, 21));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Calgary, DestinationCard.City.SaltLakeCity, 7));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Denver, DestinationCard.City.Pittsburgh, 11));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Helena, DestinationCard.City.LosAngeles, 8));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Calgary, DestinationCard.City.Phoenix, 13));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Chicago, DestinationCard.City.SantaFe, 9));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Toronto, DestinationCard.City.Miami, 10));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Dallas, DestinationCard.City.NewYork, 11));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Duluth, DestinationCard.City.Houston, 8));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.SaultSaintMarie, DestinationCard.City.Nashville, 8));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Duluth, DestinationCard.City.ElPaso, 10));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Winnipeg, DestinationCard.City.Houston, 12));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Denver, DestinationCard.City.ElPaso, 4));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.LosAngeles, DestinationCard.City.Miami, 20));
        DestinationCards.Add(new DestinationCard(DestinationCard.City.Portland, DestinationCard.City.Phoenix, 11));

        DestinationCards = DestinationCards.Shuffle();
    }


    private void CreateTrainCardDeck()
    {
        var deck = new List<TrainCard>();
        deck.AddRange(CreateSingleColorCollection(TrainColor.Red, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.Purple, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.Blue, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.Green, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.Yellow, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.Orange, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.Black, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.White, 12));
        deck.AddRange(CreateSingleColorCollection(TrainColor.Locomotive, 14));

        deck.Shuffle();

        this.Deck = deck;
    }


    private List<TrainCard> CreateSingleColorCollection(TrainColor colour, int count)
    {
        List<TrainCard> cards = new List<TrainCard>();
        for (int i = 0; i < count; i++)
        {
            cards.Add(new TrainCard() { Colour = colour });
        }
        return cards;
    }

    public void FlipShownCards()
    {
        while (ShownCards.Count < 5)
        {
            var newCard = Deck.Pop(1);
            ShownCards.AddRange(newCard);
        }
    }

    public void PopulateShownCards()
    {
        if (Deck.Count < 10)
        {
            //Shuffle the discard pile into the deck
            var allCards = DiscardPile;
            allCards.AddRange(Deck.Pop(Deck.Count));

            allCards.Shuffle();

            Deck = allCards;
            DiscardPile = new List<TrainCard>();
        }

        FlipShownCards();

        var locomotiveCount = ShownCards.FindAll(x => x.Colour == TrainColor.Locomotive).Count;
        while (locomotiveCount >= 3)
        {
            Debug.Log("Shown cards has 3 or more locomotives! Burning the shown cards.");

            //Discard the shown cards
            DiscardPile.AddRange(ShownCards);
            ShownCards = new List<TrainCard>();

            //Add a new set of shown cards
            FlipShownCards();
            locomotiveCount = ShownCards.Where(x => x.Colour == TrainColor.Locomotive).Count();
        }
    }
}