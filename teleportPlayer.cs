using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportPlayer : MonoBehaviour // Script governing the teleportation of the player
{
    public Transform teleportLocation; // Location of the teleportation

    private void OnTriggerEnter(Collider other) { // Upon the player colliding with this, the Player is then teleported to another location
        if (other.CompareTag("Player")) {
            other.transform.position = teleportLocation.position;
        }
    }
}
