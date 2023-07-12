using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference to the player object
    private Vector3 offset = new Vector3(0, 5, -7); // Offset the camera behind the player by adding to the player's position

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset; // Set the position of the camera to the position of the player
    }
}
