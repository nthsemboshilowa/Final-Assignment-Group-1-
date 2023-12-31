using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CardExtensions
{
    public static List<TrainCard> GetMatching(this List<TrainCard> cards, TrainColor color, int count)
    {
        if (cards.Count(x => x.Colour == color) >= count)
        {
            var selectedCards = cards.Where(x => x.Colour == color).Take(count).ToList();
            foreach (var card in selectedCards)
            {
                cards.Remove(card);
            }

            return selectedCards;
        }

        return new List<TrainCard>();
    }

    public static List<TrainCard> Pop(this List<TrainCard> cards, int count)
    {
        List<TrainCard> returnCards = new List<TrainCard>();
        for (int i = 0; i < count; i++)
        {
            var selectedCard = cards[0];
            cards.RemoveAt(0);
            returnCards.Add(selectedCard);
        }

        return returnCards;
    }

    public static List<DestinationCard> Pop(this List<DestinationCard> cards, int count)
    {
        List<DestinationCard> returnCards = new List<DestinationCard>();
        for (int i = 0; i < count; i++)
        {
            var selectedCard = cards[0];
            cards.RemoveAt(0);
            returnCards.Add(selectedCard);
            if (!cards.Any()) break;
        }

        return returnCards;
    }

    public static TrainColor GetMostPopularColor(this List<TrainCard> cards, List<TrainColor> desiredColors)
    {
        if (!cards.Any())
            return TrainColor.Locomotive;

        var colors = cards.Where(x => x.Colour != TrainColor.Locomotive)
            .GroupBy(x => x.Colour)
            .Select(group =>
                new
                {
                    Color = group.Key,
                    Count = group.Count()
                })
            .OrderByDescending(x => x.Count)
            .Select(x => x.Color)
            .ToList();
        var selectedColor = colors.First();

        var otherColors = colors.Except(desiredColors);
        if (otherColors.Any())
        {
            while (desiredColors.Contains(selectedColor))
            {
                colors.Remove(selectedColor);
                selectedColor = colors.First();
            }
        }

        return selectedColor;
    }

    public static List<DestinationCard> Shuffle(this List<DestinationCard> cards)
    {
        System.Random r = new System.Random();
        //Step 1: For each unshuffled item in the collection
        for (int n = cards.Count - 1; n > 0; --n)
        {
            //Step 2: Randomly pick an item which has not been shuffled
            int k = r.Next(n + 1);

            //Step 3: Swap the selected item with the last "unstruck" letter in the collection
            DestinationCard temp = cards[n];
            cards[n] = cards[k];
            cards[k] = temp;
        }

        return cards;
    }

    public static List<TrainCard> Shuffle(this List<TrainCard> cards)
    {
        System.Random r = new System.Random();
        //Step 1: For each unshuffled item in the collection
        for (int n = cards.Count - 1; n > 0; --n)
        {
            //Step 2: Randomly pick an item which has not been shuffled
            int k = r.Next(n + 1);

            //Step 3: Swap the selected item with the last "unstruck" letter in the collection
            TrainCard temp = cards[n];
            cards[n] = cards[k];
            cards[k] = temp;
        }

        return cards;
    }
}





