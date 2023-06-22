using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainCarCards : MonoBehaviour
{
    [Header("UI")]
    public Image image;
    public TrainCard TrainCard;

    [HideInInspector] public TrainCard trainCard;
    public void InitialiseItem(TrainCard trainCard)
    {
        TrainCard = trainCard;
        image.sprite = trainCard.image;
        //RefreshCount();
    }
}
