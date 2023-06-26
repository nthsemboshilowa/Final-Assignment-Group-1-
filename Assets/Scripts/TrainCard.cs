using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TrainColour;
using UnityEngine.UI;


public class TrainCard : MonoBehaviour
{
    public TrainColor Colour;

    public Image image;

    public int handIndex;
}

public enum TrainColor
{
    Blue, Red, Green, Yellow, Black, Purple, Orange, White, Locomotive
}
