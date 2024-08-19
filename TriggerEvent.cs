using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public MutantAgent mutantAgent;
   
   private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Player")) {
        mutantAgent.activate();
    }
   
   }
}
