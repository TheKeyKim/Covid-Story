using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{


    private Transform player;       // Reference to the player's transform.
    public Vector3 movement = new Vector3(-0.5f,0.0f,0.0f);

    void Awake()
    {
        

    }


    private void LateUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }

}
