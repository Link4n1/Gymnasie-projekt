using UnityEngine;

public class Place : MonoBehaviour
{
    [SerializeField] private GameObject reciver;
    [SerializeField] private GameObject giver;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlaceReciver();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlaceGiver();
        }
      


    }
    void PlaceGiver()
    {
        Instantiate(giver, Vector3.zero, Quaternion.identity);
    }

    void PlaceReciver()
    {
        Instantiate(reciver, Vector3.zero, Quaternion.identity);
    }
   
}
