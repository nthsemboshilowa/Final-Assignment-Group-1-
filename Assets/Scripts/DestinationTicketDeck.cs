using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestinationTicketDeck : MonoBehaviour
{
    public DestinationCard[] DestinationCards;
    public List<DestinationCard> DestinationCard = new List<DestinationCard>();

    public Transform[] DestinationSlots;

    public bool[] availableDestinationSlots;

    private int drawnCardCount = 0;

    private void Start()
    {
        PopulateCardSlots();

    }

    private void PopulateCardSlots()
    {
        List<int> availableIndices = new List<int>(); // Track the available indices in the deck
        for (int i = 0; i < DestinationCard.Count; i++)
        {
            availableIndices.Add(i);
        }

        for (int i = 0; i < DestinationSlots.Length; i++)
        {
            if (availableIndices.Count > 0)
            {
                int randomIndex = Random.Range(0, availableIndices.Count);
                int deckIndex = availableIndices[randomIndex];
                availableIndices.RemoveAt(randomIndex); // Remove the selected index from the available indices

                DestinationCard card = DestinationCards[deckIndex];
                RectTransform cardRectTransform = card.GetComponent<RectTransform>();

                cardRectTransform.SetParent(DestinationSlots[i]);
                cardRectTransform.anchoredPosition = Vector2.zero;
                cardRectTransform.localScale = Vector3.one;
                cardRectTransform.rotation = Quaternion.identity; // Set rotation to identity (0, 0, 0)
              
                card.gameObject.SetActive(true);
            }
            else
            {
                // No more cards in the deck, disable the card slot
                availableDestinationSlots[i] = false;
                DestinationSlots[i].gameObject.SetActive(false);
            }
        }


    }

        public void DrawTicket()
    {
        if (drawnCardCount >= 3)
        {
            Debug.Log("You have already drawn 3 destination cards in this turn.");
            return;
        }

        if (DestinationCard.Count > 0)
        {
            int randomIndex = Random.Range(0, DestinationCard.Count);
            DestinationCard ticket = DestinationCard[randomIndex];
            DestinationCard.RemoveAt(randomIndex);
            drawnCardCount++;

            // Add the ticket to the player's hand or display it in UI
            // For now, we'll simply log the ticket's information
            Debug.Log("Drawn Ticket: " + ticket.ToString());

            if (drawnCardCount >= 3)
            {
                // Disable the drawDestinationTicketsButton
                PlayerTurn playerTurn = FindObjectOfType<PlayerTurn>();
                if (playerTurn != null)
                {
                    Button drawDestinationTicketsButton = playerTurn.drawDestinationTicketsButton;
                    if (drawDestinationTicketsButton != null)
                    {
                        drawDestinationTicketsButton.interactable = false;
                    }
                }
            }
        }
        else
        {
            Debug.Log("No more destination cards available.");
        }
    }
}

