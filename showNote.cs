using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showNote : MonoBehaviour // Script governing the pop up of the notes
{
    public GameObject note; // variabel to hold the note canvases
    
    public Button closeNoteButton;

    void Start () { // Upon loading te game, ensure the notes do not pop up on the screen
        note.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) { // Once the player enters the note object's collider, call the openNote function
        if (other.CompareTag("Player")) {
            openNote();
            
        }
    }

    public void openNote() { // show the note's content
        note.SetActive(true);
        
    }

    public void closeNote() { // close the note upon clicking the 'Close' button
        note.SetActive(false);
        
    }


}
