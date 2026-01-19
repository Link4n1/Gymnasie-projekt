using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Sprite baseTexture, sandTexture, coalTexture, ironTexture;
    [SerializeField] private SpriteRenderer _renderer;
    private string _material;
    public bool IsGiver = false;
    public bool IsOccupied = false;
    public void Init(string material)
    {
        _material = material;
        switch (material)
        {
            case "Sand":
                _renderer.sprite = sandTexture;
                break;
            case "Coal":
                _renderer.sprite = coalTexture;
                break;
            case "Iron":
                _renderer.sprite = ironTexture;
                break;
            default:
                _renderer.sprite = baseTexture;
                break;
        }

    }
    public bool MayPlace()
    {
        if (IsOccupied)
        {
            Debug.Log("Tile is occupied");
            return false;
        }
        switch (_material)
        {
            case "Sand":
                return true;
            default:
                return true;
        }
    }
}
