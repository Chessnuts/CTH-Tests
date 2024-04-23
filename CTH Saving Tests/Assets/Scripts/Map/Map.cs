using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Private Variables
// -------------------------------------
    // Map Size
    [SerializeField] private int mapHeight = 0;
    [SerializeField] private int mapWidth = 0;

    // Map Loading options
    [SerializeField] private bool loadFromTileMap;
    [SerializeField] private bool loadFromFile;

    //

    // References
// ----------------------------------------
    [SerializeField] private TileReferenceList tileTypes;

    void Start()
    {
        GetMapData(); //Get the data of the map
        // Initialise the map
        // Link the map up
        // Load the tile data
        // Render the map
    }

    // Want to get map data before Initialisation
    private void GetMapData()
    {
        if(loadFromTileMap) // To Do
        {
            //Do stuff
            //if checked and nothing is found, will probably move on to next one so yeah
        }

        // Default Map Size (perfect for testing)
        if (mapHeight == 0 || mapWidth == 0)
        {
            mapHeight = 32;
            mapWidth = 32;
        }
    }

    // Generate the array of map point
    private void InitialiseMap()
    {

    }

}
