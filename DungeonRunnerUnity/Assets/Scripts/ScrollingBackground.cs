using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    public GameObject TilemapBase;
    public GameObject TilemapBase2;


    private float beginTarget;
    private float endTarget;

    public float m_scrollSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        beginTarget = 17.829f;
        endTarget = -17.829f;
    }

    // Update is called once per frame
    void Update()
    {
        TilemapBase.transform.position += -transform.right * m_scrollSpeed * Time.deltaTime;
        TilemapBase2.transform.position += -transform.right * m_scrollSpeed * Time.deltaTime;

    if(TilemapBase.transform.position.x < endTarget){
        TilemapBase.transform.position = new Vector3(TilemapBase2.transform.position.x +18.0f, TilemapBase2.transform.position.y, TilemapBase2.transform.position.z);
    }

    if(TilemapBase2.transform.position.x < endTarget){
        TilemapBase2.transform.position = new Vector3(TilemapBase2.transform.position.x +36.0f, TilemapBase2.transform.position.y, TilemapBase2.transform.position.z);
    }
    }
}
