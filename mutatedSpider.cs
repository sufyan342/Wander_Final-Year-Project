using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using StarterAssets;

public class mutatedSpider : MonoBehaviour // Script governing the mutatedSpider
{
    public Transform player;
    private bool isActivated = false;
    private NavMeshAgent mutantSpider;

    public FirstPersonController playerControl; // A public field for the Player's FirstPersonController
    private Collider trigger; // A variable for the GameObject's (Mutant Spider) collider
    void Start()
    {
        mutantSpider = GetComponent<NavMeshAgent>();
        mutantSpider.speed = 1000f; // hardcoded speed for the spider
        trigger = GetComponent<Collider>(); // the trigger from the spider is assigned to the variable

        if (playerControl == null) { // check to see if this variable is empty. For testing purposes.
            Debug.LogError("NULL");
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (isActivated) {
            mutantSpider.SetDestination(player.position);

            if (playerControl != null) { // if playerControl has a FirstPersonControl, disable the controller
                playerControl.enabled = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other) { // Upon colliding with the player, destroy the spider.
        if (other.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }

    private void OnDestroy() { // Enable the player's controller once the GameObject (Mutant Spider) has been destroyed
        if(playerControl != null) {
            playerControl.enabled = true;
        }
    }

    public void activate() {
        isActivated = true;
        
    }
}