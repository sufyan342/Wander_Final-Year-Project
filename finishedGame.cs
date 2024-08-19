using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishedGame : MonoBehaviour //  Script to load the finished game menu
{
    public MapInteraction mapInteraction;
    private string finished = "finished";

    private void OnTriggerEnter(Collider other) { // conditions to checl once the collision occurs
        if (other.CompareTag("Player") && mapInteraction.collectedPieces()) {
            SceneManager.LoadScene(finished); // load finished game scene
        }

        else {
            Debug.Log("You can't escape yet..."); // Alers the player they need more map pieces
        }
    } 
    
}
