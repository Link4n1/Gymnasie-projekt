using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SquareGrid : MonoBehaviour
{

    [SerializeField] private int _width, hight;

    [SerializeField] private Tile _tilePrefab;

    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for(int x = 0; x < _width; x++)
        { for(int y = 0; y < hight; y++)
            {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                var material = "Sand";
                var rng = Random.Range(0f, 1f);
                if  (rng < 0.1)
                {
                    material = "Coal";
                } else if (rng < 0.2)
                {
                    material = "Wood";
                }
                
                spawnedTile.Init(material);


            }
        }
    }

    
}
