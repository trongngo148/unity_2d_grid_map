using CodeMonkey.Utils;
using UnityEngine;

public class Grid
{
    private int _width;
    private int _height;
    private readonly float _cellSize;
    private readonly int[,] _gridArray;
    
    public Grid(int width, int height, float cellSize)
    {
        _height = height;
        _width = width;
        _cellSize = cellSize;

        _gridArray = new int[width, height];
        
        for (var x = 0; x < _gridArray.GetLength(0); x++)
        {
            for (var y = 0; y < _gridArray.GetLength(1); y++)
            {
                UtilsClass.CreateWorldText(_gridArray[x, y].ToString(), null, GetWorldPosition(x, y), 20, Color.white, TextAnchor.MiddleCenter);
                Debug.Log(x + ", " + y);
            }
        }
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * _cellSize;
    }
    
}
