using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    public float ypos = 0.0f;
    public float xpos = 1.5f;
    public float alpha = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().position =  new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x+xpos, ypos, 0);
        GetComponent<SpriteRenderer>().color = new Vector4(GetComponent<SpriteRenderer>().color.r,GetComponent<SpriteRenderer>().color.g,GetComponent<SpriteRenderer>().color.b,alpha);
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<Transform>().position =  new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x+xpos, ypos, 0);
    }
}
