using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class TrainColour : MonoBehaviour
{
    public TrainColor colour;
    public enum TrainColor
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple,
        Black,
        White,
        Locomotive, //Only used for cards
        Grey //Only used for board spaces
    }
}

