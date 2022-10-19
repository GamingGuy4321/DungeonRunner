using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject m_gravePrefab;

    private float m_startTime;
    private float m_timertime;

    // Start is called before the first frame update
    void Start()
    {
        m_startTime = Time.time;
        m_timertime = Random.Range(0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - m_startTime > m_timertime){
            Instantiate(m_gravePrefab, transform.position, Quaternion.identity);

            m_startTime = Time.time;

        }
    }
}
