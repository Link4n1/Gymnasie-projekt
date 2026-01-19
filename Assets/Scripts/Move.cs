using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.EventSystems;
using UnityEditor;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;


public class Move : MonoBehaviour
{
    public bool placed;
    Tile currentTile;
    

    private void Start()
    {
       
       placed = false;
    }
    public void MoveObject()
    {
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);


        if (hit.collider == null)
        {
            return;
            
        }
        
        Tile tile = hit.collider.GetComponent<Tile>();

        if (tile== null)  
        {
            return;
        }

        currentTile = tile;

       if (tile.MayPlace() == true)
       {
        transform.position = hit.collider.transform.position;
       }
        

    }
    
    void Update()
    {
        if (placed)
        {
            return;
        }

        MoveObject();
        if (Input.GetMouseButtonDown(0))
        {
            if (currentTile == null)
            {
                return;
            }

            if (currentTile.MayPlace())
            {
                
                placed = true;
                currentTile.IsOccupied = true;

            }

            

        }


    }

 
}