using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefTest : MonoBehaviour
{

    [SerializeField] private int numberOfTimesSpaceKeyPressed;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("space")){
            numberOfTimesSpaceKeyPressed = PlayerPrefs.GetInt("space");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            numberOfTimesSpaceKeyPressed++;
        }
    }

    void OnDestroy() {
        PlayerPrefs.SetInt("space", numberOfTimesSpaceKeyPressed);
    }
}
