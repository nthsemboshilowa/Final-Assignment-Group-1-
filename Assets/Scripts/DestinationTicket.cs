using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestinationTicket : MonoBehaviour
{

    [Header("UI")]
    public Image image;
    public DestinationCard DestinationCard;

    [HideInInspector] public DestinationCard destinationCard;
    public void InitialiseItem(DestinationCard destinationCard)
    {
        DestinationCard = destinationCard;
        image.sprite = destinationCard.image;
        //RefreshCount();
    }
}
