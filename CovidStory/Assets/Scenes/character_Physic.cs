using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_Physic : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 speed = new Vector2(50,50);
    private Vector2 movement;

    Rigidbody2D player;
    void Start()
    {
        player = GetComponent < Rigidbody2D > ();

    }

    // Update is called once per frame
    void Update()
    {
        //speed = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D > ().velocity;
        movement = speed;
    }

    void FixedUpdate()
    {
        player.velocity = movement;
    }
}
