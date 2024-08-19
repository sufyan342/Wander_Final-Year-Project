using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class finalEvent : MonoBehaviour
{
    public Transform player; // Player position
    private NavMeshAgent mutantBaby; // AI component of the Fnal NPC
    private float playerRun = 70f;
    private bool isActivated = false; // Set to false so the NPC does not immediately spawn

    public AudioSource sound;

    
    void Start()
    {
        mutantBaby = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update() {
        if (isActivated) {
            mutantBaby.SetDestination(player.position);
            mutantBaby.speed = playerRun + 10.0f;
            sound.Play();
            // Once the activate function is called, the NPC chases the player. The sound also plays.

        }
        
    }

    public void activate() { // the activate function
        isActivated = true;
    }
   
}