using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour // Script which upon clicking the respective buttons, loads or quits the game.
{
    public void playGame() {
        SceneManager.LoadScene("Wander");
    }

    public void quitGame() {
        Application.Quit();
    }
}
