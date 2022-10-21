using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof (Slider))]
public class AudioManager : MonoBehaviour
{

    Slider slider{
        get { return GetComponent<Slider>();}
    }


    public AudioMixer mixer;
    public string volumeName;


    public void UpdateValueOnChange(float value){
        mixer.SetFloat(volumeName, value);
    }
}
