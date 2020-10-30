using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float sp = 0.1f;
    public Vector2 pos;
    public Vector2 movement = new Vector2(3.0f, 0.0f);

    int state = 0;

    Rigidbody2D player;
    Rigidbody2D camera1;
    Animator animator;
    private float time = 0.0f;
    private float jumptime = 0.0f;
    private float lastattack = 0.0f;
    private Vector3 Rotation = new Vector3(.0f,.0f,.0f);
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        player.velocity = movement;
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
        Debug.Log(player.velocity.x);
        Debug.Log(GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Rigidbody2D>().velocity.x);
        time += Time.deltaTime;
        if(state == 0 && r){
            lastattack = time;

            animator.SetBool("attack", true);
        }
        else if(state == 0 && l){
            state = 1;
            GetComponent<Rigidbody2D>().AddForce(50*Vector2.up, ForceMode2D.Impulse);
        }
        else if(state == 1 && r){
            state = 4;
        }
        else if(animator.GetBool("attack") == true){
            animator.SetBool("attack", false);
        }
    }
}
