using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Drill : MonoBehaviour
{

 
    private int drillSpeed = 1;
    private float iron = 0f;
    bool placed;
    Tile currentTile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlaceOnTile(Tile tile)
    {
        if (tile == null)
        {
            return;
        }
        currentTile = tile;
        placed = true;

        transform.position = tile.transform.position;
        tile.IsOccupied = true;
        tile.IsGiver = true;

    }

    void Update()
    {

        if (placed)
        {
            iron += drillSpeed * Time.deltaTime;
            Debug.Log("Drilling... Iron collected: " + iron);

        }

    }
}

