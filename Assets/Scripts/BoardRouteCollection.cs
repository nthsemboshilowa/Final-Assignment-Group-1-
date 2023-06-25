using System.Collections.Generic;
using UnityEngine;

public class BoardRouteCollection : MonoBehaviour
{
    public List<BoardRoute> Routes = new List<BoardRoute>();

    public void AddRoute(BoardRoute.City origin, BoardRoute.City destination, BoardRoute.TrainColour colour, int length)
    {
        Routes.Add(new BoardRoute(origin, destination, colour, length));
    }


}


