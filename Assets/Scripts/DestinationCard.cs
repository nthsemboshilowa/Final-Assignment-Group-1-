using System.Collections;
using System.Collections.Generic;
using TicketToRide.Enums;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Destination Cards")]
public class DestinationCard : ScriptableObject
{

    public City Origin;
    public City Destination;

    public int PointValue;

    public Sprite image;


    public DestinationCard(City origin, City destination, int points)
    {
        Origin = origin;
        Destination = destination;
        PointValue = points;
    }

    public enum City
    {
        Atlanta,
        Boston,
        Calgary,
        Charleston,
        Chicago,
        Dallas,
        Denver,
        Duluth,
        ElPaso,
        Helena,
        KansasCity,
        Houston,
        LittleRock,
        LasVegas,
        LosAngeles,
        Miami,
        Montreal,
        Nashville,
        NewOrleans,
        NewYork,
        OklahomaCity,
        Omaha,
        Phoenix,
        Pittsburgh,
        Portland,
        Raleigh,
        SaintLouis,
        SaltLakeCity,
        SanFrancisco,
        SantaFe,
        SaultSaintMarie,
        Seattle,
        Toronto,
        Vancouver,
        Washington,
        Winnipeg
    }
}



