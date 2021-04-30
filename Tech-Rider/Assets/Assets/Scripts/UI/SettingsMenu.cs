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

    public void SetMusicVolume (float volume)
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

    public void SetMasterVolume(float volume)
    {        
        audioMixer.SetFloat("volume", volume);
    }

    public void MuteAudio(bool ismute)
    {
        //if (ismute)
        //{
        //    audioMixer.SetFloat("volume", 0f);
        //}
        
        //if (!ismute)
        //{
        //    audioMixer.SetFloat("volume", volumneslider.value);
        //}
        
    }
}
