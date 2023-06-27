using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Button Draw;
    public PlayerTurn playerTurn;

    public List<TrainCard> deck = new List<TrainCard>();
    public List<Card> discardPile = new List<Card>();
    public List<PlayerHand> Hand = new List<PlayerHand>();

    public Transform[] cardSlots;
    public Transform[] handSlots;

    public bool[] availableCardSlots;
    public bool[] availableHandSlots;

    public Text deckSizeText;
    public Text discardPileText;

    private int drawnCardCount = 0;

    private void Start()
    {
        PopulateCardSlots();

    }

    private void PopulateCardSlots()
    {
        List<int> availableIndices = new List<int>(); // Track the available indices in the deck
        for (int i = 0; i < deck.Count; i++)
        {
            availableIndices.Add(i);
        }

        for (int i = 0; i < cardSlots.Length; i++)
        {
            if (availableIndices.Count > 0)
            {
                int randomIndex = Random.Range(0, availableIndices.Count);
                int deckIndex = availableIndices[randomIndex];
                availableIndices.RemoveAt(randomIndex); // Remove the selected index from the available indices

                TrainCard card = deck[deckIndex];
                RectTransform cardRectTransform = card.GetComponent<RectTransform>();

                cardRectTransform.SetParent(cardSlots[i]);
                cardRectTransform.anchoredPosition = Vector2.zero;
                cardRectTransform.localScale = Vector3.one;
                cardRectTransform.rotation = Quaternion.identity; // Set rotation to identity (0, 0, 0)
                card.handIndex = i;
                card.gameObject.SetActive(true);
            }
            else
            {
                // No more cards in the deck, disable the card slot
                availableCardSlots[i] = false;
                cardSlots[i].gameObject.SetActive(false);
            }
        }

        for (int i = 0; i < 4; i++)
        {
            if (availableIndices.Count > 5)
            {
                int randomIndex = Random.Range(0, availableIndices.Count);
                int deckIndex = availableIndices[randomIndex];
                availableIndices.RemoveAt(randomIndex); // Remove the selected index from the available indices

                TrainCard card = deck[deckIndex];
                RectTransform cardRectTransform = card.GetComponent<RectTransform>();

                cardRectTransform.SetParent(handSlots[i]);
                cardRectTransform.anchoredPosition = Vector2.zero;
                cardRectTransform.localScale = Vector3.one;
                cardRectTransform.localRotation = Quaternion.identity; // Set rotation to identity (0, 0, 0)
                card.handIndex = i;
                card.gameObject.SetActive(true);
            }
            else
            {
                // No more cards in the deck, disable the card slot
                availableHandSlots[i] = false;
                handSlots[i].gameObject.SetActive(false);
            }
        }
    }

    public void DrawCard()
    {
        if (drawnCardCount >= 2)
        {
            Debug.Log("You have already drawn 2 train cards in this turn.");
            return;
        }

        if (deck.Count >= 1)
        {
            TrainCard randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i])
                {
                    randCard.gameObject.SetActive(true);
                    randCard.handIndex = i;

                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(randCard);

                    drawnCardCount++;

                    if (drawnCardCount >= 2)
                    {
                        Draw.interactable = false; // Disable the Draw button
                        playerTurn.EndPlayerTurn();
                    }

                    return;
                }
            }
        }
    }

    private void Update()
    {
      //  deckSizeText.text = deck.Count.ToString();
      //  discardPileText.text = discardPile.Count.ToString();
    }
}


