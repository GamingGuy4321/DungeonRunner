using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     // public static instance of the GameManager, Initiailized to 'null' to ensure it's empty to start
    public static GameManager Instance = null;
    // public reference of the PauseMenu object to allow access to turn the gameobject on and off when the game is paused
    public GameObject m_pauseMenu;

    public GameObject m_LoseMenu;

    public bool m_isLost;
    // public bool to track if the game is in a paused state or not
    public bool m_isPaused;
    void Awake() {
        // On Awake, create the instance of the GameManager that will be used for the duration of the program
        SetInstance();
    }

    void Start(){
        m_pauseMenu.SetActive(false);
    }
    void SetInstance(){
        // Check if this script/object is being used as the Instance of the GameManager
        // If not, destroy that imposter and use this script/object instead
        if (Instance == null) {
            Instance = this;
        } else if (Instance != this) {
            Destroy(gameObject);
        }
        // Don't Destroy this gameobject if another scene is loaded
        // Will seperate this gameobject into it's own instance that exists below the active scene in unity
        DontDestroyOnLoad(gameObject);
    }
    // Function to pause the game and activate the PauseMenu object
    public void PauseGame() {
        // Check to make sure the bool is false, indicating that the game is NOT paused at the moment...
        if (!m_isPaused) {
            // Set the timescale of the game to 0. This will disable actions/movements based on Rigidbodies.
            Time.timeScale = 0;
            // Set the m_isPaused bool to true, indicating a paused gamestate.
            m_isPaused = true;
            // Turn on the PauseMenu gameobject
            m_pauseMenu.SetActive(true);
        }
    }
    // Function to unpause the game and deactivate the PauseMenu object
    public void UnpauseGame() {
        // Check to make sure the bool is true, indicating that the game IS paused at the moment...
        if(m_isPaused) {
            // Set the timescale of the game to 1.  This will enable actions/movements based on Rididbodies.
            Time.timeScale = 1;
            // Set the m_isPaused bool to false, indicating an unpaused gamestate
            m_isPaused = false;
            // Turn off the PauseMenu gameobject
            m_pauseMenu.SetActive(false);
        }
    }

    // Function to pause the game and activate the PauseMenu object
    public void LoseGame() {
        // Check to make sure the bool is false, indicating that the game is NOT paused at the moment...
        if (!m_isLost) {
            // Set the timescale of the game to 0. This will disable actions/movements based on Rigidbodies.
            Time.timeScale = 0;
            // Set the m_isPaused bool to true, indicating a paused gamestate.
            m_isLost = true;
            // Turn on the PauseMenu gameobject
            m_LoseMenu.SetActive(true);
        }
    }
}
