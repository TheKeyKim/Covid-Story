using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{


    private Transform player;       // Reference to the player's transform.
    private Vector2 pos1;
    private Vector2 pos2;

    void Awake()
    {
        // Setting up the reference.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        pos1 = GameObject.FindGameObjectWithTag("Finish").transform.position;
        pos2 = GameObject.FindGameObjectWithTag("Finish").transform.position;

    }


    private void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, 0, -10.0f);
        
    }

}
