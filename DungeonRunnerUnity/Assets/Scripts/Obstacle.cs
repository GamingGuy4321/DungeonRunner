using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float m_scrollSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.right * m_scrollSpeed * Time.deltaTime;
        if (transform.position.x < -15){
            Destroy(gameObject);
        }
    }
}
