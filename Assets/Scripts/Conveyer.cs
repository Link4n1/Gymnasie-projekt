using UnityEngine;

public class Conveyer : MonoBehaviour
{
    [SerializeField] private Sprite conN, conS, conE, conW;
    private Tile lastTile;
    private bool isDragging;
    bool placed;
    bool startMove;
    

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Use a point check to find the collider under the cursor
        Collider2D hit = Physics2D.OverlapPoint(mouseWorldPos);




        if (Input.GetMouseButtonDown(0))
        {
            if (hit != null && hit.TryGetComponent<Tile>(out Tile tile) && tile.IsGiver)
            {
                return;
            }
            

        }

     
    }
}
