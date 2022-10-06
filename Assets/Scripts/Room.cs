using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public Vector2 gridPosition;

    public int roomType;

    public bool doorNorth;
    public bool doorEast;
    public bool doorSouth;
    public bool doorWest;

    public Room(Vector2 gridPos, int type)
    {
        gridPosition = gridPos;
        roomType = type;
    }
}
