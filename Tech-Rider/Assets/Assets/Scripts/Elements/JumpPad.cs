using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public GameObject Player;
    public Vector2 jumppadforce;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player.GetComponent<Rigidbody2D>().AddForce(jumppadforce);
        }
    }

    private void Start()
    {
        Player = FindObjectOfType<CarController>().gameObject;
    }
}
