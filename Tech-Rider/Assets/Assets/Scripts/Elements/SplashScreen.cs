using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public LevelLoader levelloader_script;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, false);

        if (GetComponent<AudioSource>() == null)
        {
            gameObject.AddComponent<AudioSource>();
        }
        StartCoroutine(LoadMainMenu());

        GetComponent<AudioSource>().playOnAwake = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMainMenu()
    {
        yield return new WaitForSeconds(7);
        levelloader_script.LoadNextLevel();
    }
}
