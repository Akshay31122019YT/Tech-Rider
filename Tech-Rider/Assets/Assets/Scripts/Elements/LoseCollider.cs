using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    public GameObject LoseMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            LoseMenu.SetActive(true);
        }
    }

    private void Start()
    {
        LoseMenu.SetActive(false);
    }

}
