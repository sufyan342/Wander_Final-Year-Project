using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mutatedPriest : MonoBehaviour // Script governing the behaviour of the Mutated Priest
{
    public Transform player;
    private bool isActivated = false;
    private NavMeshAgent mutantPriest;
    private float playerRun = 70f; // Compared to the Mutant Man script, this has been hardcoded.
    void Start()
    {
        mutantPriest = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated) {
            mutantPriest.SetDestination(player.position);
            mutantPriest.speed = playerRun + 5.0f; // Another difference is an additional 5 units of speed is added on top.

        }
    }

    public void activate() {
        isActivated = true;
    }
}