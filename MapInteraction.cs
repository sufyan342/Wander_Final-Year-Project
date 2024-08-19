using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MapInteraction : MonoBehaviour // Script governing the map interactions
{

    private bool pickedUp = false; // Set to false so the map piece can be picked up. 
    public TextMeshProUGUI mapPiecesCounterText;
    private static int mapCounter = 0; // set to zero to start

    private int totalMapPieces = 3; // maximum number of map pieces

    void OnTriggerEnter(Collider other) { // condition which upon colliding, and with pickedUp being false, increments the counter and destroys the book
        if(other.CompareTag("Player") && !pickedUp) {
            pickedUp = true;
            updateMapPieces();
            Destroy(gameObject);
            
        }
    }

    

    void updateMapPieces() { // increments the map counter
        mapCounter++;
        mapPiecesCounterText.text = "Map Pieces: " + mapCounter; 
    }

    public bool collectedPieces() { // Returns true if mapCounter is greater or equal to totalMapPieces, otherwise false.
        return mapCounter >= totalMapPieces; 
    }

    public static void resetCounter() {
        mapCounter = 0;
    }
}
