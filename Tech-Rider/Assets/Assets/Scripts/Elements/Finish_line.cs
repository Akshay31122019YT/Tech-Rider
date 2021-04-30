using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Finish_line : MonoBehaviour
{
    public PostProcessVolume Postprocessingvolume;
    private ChromaticAberration chromaticalberation;    
    public LevelLoader LevelLoader;
    public GameObject YouWinUI;
    private Vignette vignete;
    public GameObject levelcanvas;
    public gamecanvasmanager gamecanvasmanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            loadyouwinscreen();
        }
    }

    private void Start()
    {
        gamecanvasmanager = FindObjectOfType<gamecanvasmanager>();
        YouWinUI.SetActive(false);
    }

    public void loadyouwinscreen()
    {
        levelcanvas.SetActive(false);
        Time.timeScale = 0.2f;
        Postprocessingvolume.profile.TryGetSettings(out vignete);
        Postprocessingvolume.profile.TryGetSettings(out chromaticalberation);
        vignete.smoothness.value = 0.6f;
        chromaticalberation.intensity.value = 1;
        YouWinUI.SetActive(true);
        FindObjectOfType<CoinManager>().Doyouwinscreeenstuf();
    }    
}
