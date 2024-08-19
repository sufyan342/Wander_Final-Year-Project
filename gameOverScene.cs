using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScene : MonoBehaviour // Script to load the game over screen
{
    private string sceneName = "gameOver";
    private void OnTriggerEnter(Collider other) { // Upon colliding, load the game over screen.
        if (other.CompareTag("Player")) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
