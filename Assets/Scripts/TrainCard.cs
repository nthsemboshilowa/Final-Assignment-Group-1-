using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TrainColour;


public class TrainCard : MonoBehaviour
{
    public TrainColor Colour;

    public Sprite image;
}

public enum TrainColor
{
    Blue, Red, Green, Yellow, Black, Purple, Orange, White, Locomotive
}
