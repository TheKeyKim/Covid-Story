using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect : MonoBehaviour
{
    private int state;
    public float ypos = 0.0f;
    public float xpos = 1.5f;
    bool done = false;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().position =  new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x+xpos, ypos, 0);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int prestate = animator.GetInteger("State");
        state = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().GetInteger("State");
        animator.SetInteger("State", state);

        if(prestate != state && prestate ==0 && state == 1){
            done = true;
            animator.SetBool("done",done);
        }
        else if(prestate != state && state ==5){
            done = true;
            animator.SetBool("done",done);
        }
        else{
            done = false;
            animator.SetBool("done",done);
        }
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("SmashEffect")){
            GetComponent<Transform>().position =  new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x+xpos - 2, ypos-0.3f, 0);
        }
        else {
            GetComponent<Transform>().position =  new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x+xpos, ypos, 0);
        }
    }
}
