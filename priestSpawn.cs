using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class priestSpawn : MonoBehaviour // Script governing the spawn of the mutatedPriest
{

    public float spawnDuration = 20f; // Spawn duration
    public GameObject mutatedPriest;
    public Transform spawn; // Location of the spawn point


    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            spawnPriest();
        }
    }
    
        
    

    public void spawnPriest() { // logic to spawn the priest. Reused from the Mutated Baby
        GameObject priest = Instantiate(mutatedPriest, spawn.position, spawn.rotation);
        mutatedPriest priestScript = priest.GetComponent<mutatedPriest>();
        if (priestScript != null) {
            priestScript.activate();
        }
        
        Destroy(priest, spawnDuration); // Destroy the priest once the spawn duration timer is up
    }
}
