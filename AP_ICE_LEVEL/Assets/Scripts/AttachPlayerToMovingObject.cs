using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayerToMovingObject : MonoBehaviour
{
    public GameObject player;
    public Transform foot;

    void OnTriggerEnter(Collider other)
    {
        // Check if the moving object is the player's left or right foot
        if (other.transform == foot)
        {
            // Attach the player to the moving object
            player.transform.parent = other.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the moving object is the player's left or right foot
        if (other.transform == foot)
        {
            // Detach the player from the moving object
            player.transform.parent = null;
        }
    }
}
