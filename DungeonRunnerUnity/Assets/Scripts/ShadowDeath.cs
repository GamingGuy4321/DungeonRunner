using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowDeath : MonoBehaviour
{
    public Animator m_animator;

    void Start()
    {
        // On start, get the Animator component and assign it to the m_animator
        m_animator = GetComponent<Animator>();
    }

       void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Trap"){
           m_animator.SetBool("Dead", true);
        }
    }
}
