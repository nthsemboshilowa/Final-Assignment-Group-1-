using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Train Cards")]
public class TrainCard : ScriptableObject
{

    public TrainCardColour colour;

    public Sprite image;
}

public enum TrainCardColour
{
    Blue, Red, Green, Yellow, Black, Purple, Orange, White, Multi
}
