using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestinationCard : MonoBehaviour
{

    public City Origin;
    public City Destination;
    public int PointValue;



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



