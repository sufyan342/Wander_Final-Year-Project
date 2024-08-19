using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderSpawn : MonoBehaviour // Script governing the spawn of the Mutant Spider. Re-used code from the other NPC spawn logic
{

    public float spawnDuration = 10f;
    public GameObject mutatedSpider;
    public Transform spawn;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            spawnSpider();
        }
    }
    
    public void spawnSpider() {
        GameObject spider = Instantiate(mutatedSpider, spawn.position, spawn.rotation);
        mutatedSpider spiderScript = spider.GetComponent<mutatedSpider>();
        if (spiderScript != null) {
            spiderScript.activate();
        }
        
        Destroy(spider, spawnDuration);
    }
}