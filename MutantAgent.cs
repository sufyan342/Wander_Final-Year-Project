using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MutantAgent : MonoBehaviour // Script governing the behaviour of the Mutant Agent
{
    public Transform player;
    private bool isActivated = false;
    private NavMeshAgent mutantAgent;
    public float playerSpeed; // filed for the player's speed


    void Start()
    {
        mutantAgent = GetComponent<NavMeshAgent>();
        mutantAgent.speed = playerSpeed; // the NPC's speed should be equal to the player's speed (whatever has been inputted)
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated) {
            mutantAgent.SetDestination(player.position);

        }
    }

    public void activate() {
        isActivated = true;
    }
}
