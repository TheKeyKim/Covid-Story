using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 pos;
    private Vector2 movement;

    Rigidbody2D player;
    Rigidbody2D camera1;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        player.velocity = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Rigidbody2D>().velocity;
    }
}
