using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float sp = 0.1f;
    public Vector2 pos;
    public Vector2 movement = new Vector2(8.0f, 0.0f);

    int state = 0;
    public float l_xpos, r_xpos;
    Rigidbody2D player;
    Rigidbody2D camera1;
    Animator animator;
    private float time = 0.0f;
    private float jumptime = 0.0f;
    private float lastattack = 0.0f;
    private Vector3 Rotation = new Vector3(.0f,.0f,.0f);
    FileStream File = null;
    StreamWriter log_out;
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        player.velocity = movement;
        File = new FileStream("output.txt", FileMode.Create, FileAccess.Write);
        log_out = new StreamWriter(File);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ground")  state = 0;
    }

    private void Update()
    {
        //0 walking
        //1 falling
        //2 up
        //3 fling
        GetComponent<Transform>().rotation =  Quaternion.Euler(0, 180, 0);
        player.velocity = new Vector2(movement.x, player.velocity.y);
        //Debug.Log(GameObject.FindGameObjectWithTag("MainCamera").transform.position.x - GetComponent<Transform>().position.x);
        animator.SetFloat("height", player.transform.position.y);
        animator.SetInteger("State", state);
        bool r = Input.GetKeyDown(KeyCode.RightArrow);
        bool l = Input.GetKeyDown(KeyCode.LeftArrow);
        bool d = Input.GetKeyDown(KeyCode.DownArrow);

        time += Time.deltaTime;
        if(r){
            r_xpos = player.position.x + 2.2f;
            Debug.Log(player.position.x+2.2+"f, "+player.position.y+"f");
            float tmp = player.position.x+2.2f;
            log_out.WriteLine("insert_Note("+tmp+"f, "+"-0.8f);");
        }
        if(l){
            l_xpos = player.position.x + 2.2f;
            Debug.Log(player.position.x+2.2+"f, "+player.position.y+"f");
            float tmp = player.position.x+2.2f;
            log_out.WriteLine("insert_Note("+tmp+"f, "+"2.3f);");
        }
        if(d){
            log_out.Close();
            File.Close();
        }
        if(state == 0 && r){
            lastattack = time;

            animator.SetBool("attack", true);
        }
        else if(state == 0 && l){
            state = 1;
            GetComponent<Rigidbody2D>().AddForce(50*Vector2.up, ForceMode2D.Impulse);
        }
        else if(state == 1 && l){
            state = 4;
            GetComponent<Rigidbody2D>().AddForce(50*Vector2.up, ForceMode2D.Impulse);
            // must be added  [ animator.SetBool("near_Note", ture); ]
        }
        else if((state == 1 || state == 4) && r){
            state = 5;
            GetComponent<Rigidbody2D>().AddForce(-50*Vector2.up, ForceMode2D.Impulse);
            // must be added  [ animator.SetBool("near_Note", ture); ]
        }
        else if(animator.GetBool("attack") == true){
            animator.SetBool("attack", false);
        }
        else if(state == 4){
            state = 1;
        }
    }
}
