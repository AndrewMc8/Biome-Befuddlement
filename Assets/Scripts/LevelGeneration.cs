using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    Vector2 worldSize = new Vector2(4, 4);

    Room[,] rooms;

    List<Vector2> takenPositions = new List<Vector2>();

    int gridSizeX, gridSizeY, numberOfRooms = 20;

    GameObject roomObj;

    void Start()
    {
        if(numberOfRooms >= (worldSize.x * 2) * (worldSize.y * 2))
        {
            numberOfRooms = Mathf.RoundToInt((worldSize.x * 2) * (worldSize.y * 2));
        }
        gridSizeX = Mathf.RoundToInt(worldSize.x);
        gridSizeY = Mathf.RoundToInt(worldSize.y);
        CreateRooms();
        SetRoomDoors();
        DrawMap();
    }

    void CreateRooms()
    {
        rooms = new Room[gridSizeX * 2, gridSizeY * 2];
        rooms[gridSizeX, gridSizeY] = new Room(Vector2.zero, 1);
        takenPositions.Insert(0, Vector2.zero);
        Vector2 checkPosition = Vector2.zero;

        float randCompare = 0.2f;
        float randCompareStart = 0.2f;
        float randCompareEnd = 0.01f;

        for (int i = 0; i < numberOfRooms - 1; i++)
        {
            float randPerc = ((float) i) / (((float)numberOfRooms - 1));
            randCompare = Mathf.Lerp(randCompareStart, randCompareEnd, randPerc);
            checkPosition = NewPosition();
        }

        if(NumberOfNeighbors(checkPosition, takenPositions) > 1 && Random.value > randCompare)
        {
            int iterations = 0;
            do
            {
                checkPosition = SelectiveNewPosition();
                iterations++;
            }
            while (NumberOfNeighbors(checkPosition, takenPositions) > 1 && iterations < 100);
            if(iterations >= 50)
            {
                print("error: Couldn't create with less neighbors than: " + NumberOfNeighbors(checkPosition, takenPositions));
            }
        }

        rooms[(int)checkPosition.x + gridSizeX, (int)checkPosition.y + gridSizeY] = new Room(checkPosition, 0);
        takenPositions.Insert(0, checkPosition);
    }

    public void SetRoomDoors()
    {
        for(int i = 0; i < ((gridSizeX * 2)); i++)
        {
            for (int j = 0; j < ((gridSizeY * 2)); j++)
            {
                if (rooms[i, j] == null) continue;

                Vector2 gridPosition = new Vector2(i, j);

                if(j - 1 < 0)
                {
                    rooms[i, j].doorSouth = false;
                }
                else
                {
                    rooms[i, j].doorSouth = (rooms[i, j - 1] != null);
                }

                if (j + 1 >= gridSizeY * 2)
                {
                    rooms[i, j].doorNorth = false;
                }
                else
                {
                    rooms[i, j].doorNorth = (rooms[i, j + 1] != null);
                }

                if (i - 1 < 0)
                {
                    rooms[i, j].doorWest = false;
                }
                else
                {
                    rooms[i, j].doorWest = (rooms[i - 1, j] != null);
                }

                if (i + 1 >= gridSizeX * 2)
                {
                    rooms[i, j].doorEast = false;
                }
                else
                {
                    rooms[i, j].doorEast = (rooms[i + 1, j] != null);
                }
            }
        }
    }

    void DrawMap()
    {
        foreach(Room room in rooms)
        {
            if (room == null) continue;

            Vector2 drawPosition = room.gridPosition;
            drawPosition.x *= 10;
            drawPosition.y *= 10;

            MapSpriteSelector mapper = Object.Instantiate(roomObj, drawPosition, Quaternion.identity).GetComponent<MapSpriteSelector>();
            mapper.type = room.roomType;
            mapper.north = room.doorNorth;
            mapper.south = room.doorSouth;
            mapper.east = room.doorEast;
            mapper.west = room.doorWest;
        }
    }

    Vector2 NewPosition()
    {
        int x = 0;
        int y = 0;
        Vector2 checkingPosition = Vector2.zero;

        do
        {
            int index = Mathf.RoundToInt(Random.value * (takenPositions.Count - 1));
            x = (int)takenPositions[index].x;
            y = (int)takenPositions[index].y;
            bool upDown = (Random.value < 0.5f);
            bool positive = (Random.value < 0.5f);

            if (upDown)
            {
                if (positive)
                {
                    y += 1;
                }
                else
                {
                    y -= 1;
                }
            }
            else
            {
                if (positive)
                {
                    x += 1;
                }
                else
                {
                    x -= 1;
                }
            }
            checkingPosition = new Vector2(x, y);
        } while (takenPositions.Contains(checkingPosition) || x >= gridSizeX || x < -gridSizeX || y >= gridSizeY || y < -gridSizeY);

        return checkingPosition;
    }

    Vector2 SelectiveNewPosition()
    {
        int index = 0;
        int inc = 0;
        int x = 0;
        int y = 0;
        Vector2 checkingPosition = Vector2.zero;

        do
        {
            inc = 0;
            do
            {
                index = Mathf.RoundToInt(Random.value * (takenPositions.Count - 1));
                inc++;
            } while (NumberOfNeighbors(takenPositions[index], takenPositions) > 1 && inc < 100);

            x = (int)takenPositions[index].x;
            y = (int)takenPositions[index].y;
            bool upDown = (Random.value < 0.5f);
            bool positive = (Random.value < 0.5f);

            if (upDown)
            {
                if (positive)
                {
                    y += 1;
                }
                else
                {
                    y -= 1;
                }
            }
            else
            {
                if (positive)
                {
                    x += 1;
                }
                else
                {
                    x -= 1;
                }
            }
            checkingPosition = new Vector2(x, y);
        } while (takenPositions.Contains(checkingPosition) || x >= gridSizeX || x < -gridSizeX || y >= gridSizeY || y < -gridSizeY);

        if(inc >= 100)
        {
            print("Error: Couldn't find any position with only one neighbor");
        }

        return checkingPosition;
    }

    int NumberOfNeighbors(Vector2 checkingPos, List<Vector2> usedpositions)
    {
        int ret = 0;

        if(usedpositions.Contains(checkingPos + Vector2.right))
        {
            ret++;
        }
        if (usedpositions.Contains(checkingPos + Vector2.left))
        {
            ret++;
        }
        if (usedpositions.Contains(checkingPos + Vector2.up))
        {
            ret++;
        }
        if (usedpositions.Contains(checkingPos + Vector2.down))
        {
            ret++;
        }

        return ret;
    }
}
