using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumneslider;

    void Start()
    {
        
    }    

    public void Setmusicactive(bool isactive)
    {
        FindObjectOfType<MusicPLayer>().gameObject.SetActive(isactive);

        if(isactive == false)
        {
            volumneslider.interactable = false;
        }

        if (isactive == true)
        {
            volumneslider.interactable = true;
        }
    }

    public void SetVolume (float volume)
    {
        FindObjectOfType<MusicPLayer>().GetComponent<AudioSource>().volume = volume;
    }

    public void SetQuality(int qualityIndex)
    {                    
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }
}
