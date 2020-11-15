using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    Animator animator;
    SpriteRenderer sr;
    bool hit = false;  // hit enemy at good timing
    bool meet; // reach the hitting box
    bool first; // first iteration
    float time = 0; // timer
    float fades = 1.0f; // alpha value
    float cpos; // character x position
    bool sound_done = false;
    private void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        first = true;
   }

    // Update is called once per frame
    private void Update()
    {
        // if hit success, then enemy dies
        cpos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.x + 1.0f;
        float l_xpos = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().l_xpos;
        float r_xpos = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().r_xpos;

        if(GetComponent<Transform>().position.x < cpos){
            meet = true;
            animator.SetBool("meet_character", true);
        }

        if (Mathf.Abs(r_xpos - GetComponent<Transform>().position.x) < 1.5f && GetComponent<Transform>().position.y == -0.8f) {
            hit = true;
            meet = true;
            animator.SetBool("meet_character", true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().r_xpos = -32.0f;
            if(!sound_done) GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().hitSound();
            sound_done = true;
        }
        if (Mathf.Abs(l_xpos - GetComponent<Transform>().position.x) < 1.5f && GetComponent<Transform>().position.y == 2.3f) {
            hit = true;
            meet = true;
            animator.SetBool("meet_character", true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().l_xpos = -32.0f;
            if(!sound_done) GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().hitSound();
            sound_done = true;
        }
        if (meet && fades > 0.0f){
            if (hit) {
                if (first) {
                    animator.SetBool("hit_success", true);
                    first = false;
                }
                time += Time.deltaTime;
                if (time >= 0.1f) {
                    fades -= 0.1f;
                    sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, fades);
                    transform.Rotate(Vector3.forward * -45);
                    time = 0;
                }
            }
            else {
                if (first) {
                    Vector2 tmp = GetComponent<Transform>().position;
                    GetComponent<Transform>().position = new Vector2(tmp.x, tmp.y + 0.4f);
                    animator.SetBool("hit_success", false);
                    first = false;
                }
                time += Time.deltaTime;
                if (time >= 0.1f) {
                    fades -= 0.1f;
                    sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, fades);
                    time = 0;
                }                
            }

        }
    }
}
