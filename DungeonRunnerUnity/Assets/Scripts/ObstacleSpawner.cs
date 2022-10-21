using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject m_ObstaclePrefab;

    private float m_startTime;
    private float m_timertime;

    // Start is called before the first frame update
    void Start()
    {
        m_startTime = Time.time;
        m_timertime = Random.Range(0.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - m_startTime > m_timertime){
            Instantiate(m_ObstaclePrefab, new Vector3(Random.Range( 8f , 18f ),Random.Range(3.5f,-5f), -1f), Quaternion.identity);

            m_startTime = Time.time;

        }
    }
}
