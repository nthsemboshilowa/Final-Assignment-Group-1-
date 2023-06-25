using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

    public class BoardRoute : MonoBehaviour
    {

    /// The "starting point" of the route.

    public City Origin;

    public City Destination;

    /// The color of train cards necessary to claim this route (can be grey)
    public TrainColour Colour;

    /// The number of cards necessary to claim this route (1-6)
    public int Length;

        /// True if the route is already claimed.
    public bool IsOccupied;

    public bool IsTunnel;

    public int LocomotiveCount;

    /// Calculated from the Length value.
    public int PointValue
        {
            get
            {
                switch (Length)
                {
                    case 1: return 1;
                    case 2: return 2;
                    case 3: return 4;
                    case 4: return 7;
                    case 5: return 10;
                    case 6: return 15;
                    default: return 1;
                }
            }
        }

        /// If not null, is the color of the player who has claimed this route.
        public PlayerColour OccupyingPlayerColour { get; set; }

        public BoardRoute(City origin, City destination, TrainColour colour, int length)
        {
            Origin = origin;
            Destination = destination;
            Colour = colour;
            Length = length;
        }

    public BoardRoute(City origin, City destination, TrainColor colour, int length, bool isTunnel)
    {
        Origin = origin;
        Destination = destination;
        Colour = (TrainColour)colour;
        Length = length;
        IsTunnel = isTunnel;
    }

    public BoardRoute(City origin, City destination, TrainColor colour, int length, int locomotiveCount)
    {
        Origin = origin;
        Destination = destination;
        Colour = (TrainColour)colour;
        Length = length;
        LocomotiveCount = locomotiveCount;
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

         public enum TrainColour
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
