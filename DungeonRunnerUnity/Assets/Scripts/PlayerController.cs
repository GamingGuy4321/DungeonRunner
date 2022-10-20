using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager m_gameManager;

    Rigidbody2D m_rigidbody;
    // Get access to the Animator on this object
    [HideInInspector]
    public Animator m_animator;
    // A simple check to see if our player is giving any movement input
    [HideInInspector]
    public bool m_isMoving = false;
    // Variables to access input from the player
    float m_horizontalMovement;
    float m_verticalMovement;
    // Speed variable to adjust how fast the player moves on screen
    public float m_moveSpeed = 5.0f;

    void Start()
    {
        // On start, get the Rigidbody2D component and assign it to m_rigidbody
        m_rigidbody = GetComponent<Rigidbody2D>();
        // On start, get the Animator component and assign it to the m_animator
        m_animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
         if (!m_gameManager.m_isPaused) {
            // Look for the Esc keypress and pause the game if Esc is pressed.
            if(Input.GetKeyDown(KeyCode.Escape)) {
                m_gameManager.PauseGame();
            }
         }else {
            // If the game is paused and the Esc key is pressed, unpause the game.
            if(Input.GetKeyDown(KeyCode.Escape)) {
                m_gameManager.UnpauseGame();
            }
        }
    }
    void FixedUpdate() {
        // Every frame, check for input from the "Horizontal" and "Vertical" inputs and assign them to the values accordingly
        m_verticalMovement = Input.GetAxisRaw("Vertical");
        // Add velocity to the Rigidbody component using the input values, adding the relative move speed we've assigned earlier
        m_rigidbody.velocity = new Vector2(0.0f, m_verticalMovement * m_moveSpeed);
    }
}
