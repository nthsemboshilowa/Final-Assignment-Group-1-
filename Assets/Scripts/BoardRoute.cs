using System;
using System.Collections.Generic;
using System.Text;
using TicketToRide.Enums;
using UnityEngine;

namespace TicketToRide
{
    public class BoardRoute : ScriptableObject
    {

        /// The "starting point" of the route.

        public City Origin { get; set; }
        public City Destination { get; set; }

        /// The color of train cards necessary to claim this route (can be grey)
        public TrainColour Colour { get; set; }

        /// The number of cards necessary to claim this route (1-6)
        public int Length { get; set; }

        /// True if the route is already claimed.
        public bool IsOccupied { get; set; }

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
        public PlayerColour? OccupyingPlayerColour { get; set; }

        public BoardRoute(City origin, City destination, TrainColour colour, int length)
        {
            Origin = origin;
            Destination = destination;
            Colour = colour;
            Length = length;
        }
    }
}