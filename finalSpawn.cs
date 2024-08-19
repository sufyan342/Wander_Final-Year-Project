using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalSpawn : MonoBehaviour
{
    public GameObject finalNPC; // The Mutant Baby
    public Transform finalSpawnPoint; // Mutant Baby spawn point
    public MapInteraction mapCollection; // Require the current map pieces from the MapInteraction script

    private void OnTriggerEnter(Collider other) { //Unity function which detects if colliders colide. 
        if (other.CompareTag("Player") && mapCollection.collectedPieces()) { //checks if collides with player, has required pieces
            spawnFinalNPC();
        }
    } 
    public void spawnFinalNPC() { // Function to spawn the Mutant Baby
        GameObject baby = Instantiate(finalNPC, finalSpawnPoint.position, finalSpawnPoint.rotation); // Create Instant of NPC
        finalEvent finalScript = baby.GetComponent<finalEvent>(); // Gets the finalEvent Script
        if (finalScript != null) {
            finalScript.activate();
        }
        
        
    }
}
