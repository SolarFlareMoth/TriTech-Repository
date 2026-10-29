using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class Astarpathfinding : MonoBehaviour
{
    //GCost is Distance to Start
    //Hcost = Distance to End
    //Fcost = Gcost + Hcost

    //A* looks for the lowest Fcost, then searches the next node

    //AW NAAAAH, HE AIN'T EVEN STARTED WITH BASICS!?

    //ok... [SerializeField] means... serializing a field? oh wait, its the cell and grid stuff

    [SerializeField] private int gridHeight = 10;
    [SerializeField] private int gridWidth = 10;
    [SerializeField] private float cellHeight = 1f;
    [SerializeField] private float cellWidth = 1f;

    [SerializeField] private bool generatePath;
    [SerializeField] private bool visualiseGrid;

    private bool pathGenerated = false;

    private Dictionary<Vector2, Cell> cells;

    private void Update()
    {
        if (generatePath && !pathGenerated)
        {
            GenerateGrid();
            pathGenerated = true;  
        }
        else if (!generatePath)
        {
            pathGenerated = false;
        }
        
    }
    
    private void GenerateGrid()
    {
        //placeholder while doing Update

        cells = new Dictionary<Vector2, Cell>();

        for (float x = 0; x < gridWidth; x += cellWidth)
        {
            for (float y = 0; y < gridHeight; y += cellHeight)
            {
                Vector2 pos = new Vector2(x, y);
                cells.Add(pos, new Cell(pos));
            }
        }

        for (int i = 0; i < 40; i++)
        {
            Vector2 pos = new Vector2(Random.Range(0, gridWidth), Random.Range(0, gridHeight));
            cells[pos].isWall = true;
        }
    }


    private class Cell
    {
        public Vector2 position;
        public int fcost;
        public int gcost;
        public int hcost;
        public Vector2 connection;
        public bool isWall;

        public Cell(Vector2 pos)
        {
            position = pos;
        }
    }
    private void OnDrawGizmos()
    {
        if (!visualiseGrid || cells == null)
        {
            return;
        }

        foreach (KeyValuePair<Vector2, Cell> kvp in cells)
        {
            if (!kvp.Value.isWall)
            {
                Gizmos.color = Color.white;
            }
            else
            {
                Gizmos.color = Color.black;
            }

            /*if (finalPath.Contains(kvp.Key))
            {
                Gizmos.color = Color.magenta;
            }

            float gizmoSize = showTexts ? 0.2f : 1;

            Gizmos.DrawCube(kvp.Key + (Vector2)transform.position, new Vector3(cellWidth, cellHeight) * gizmoSize);
            */
            //went to copy the code he used for the gizmo to ses if it'd work then, no :/

            //this is incomplete, im just trying to find out how to get it to even create the normal black and white squares
        }
    }
    //didn't even bother to read all of it, this is a guy's code from a vid he sent us

}
