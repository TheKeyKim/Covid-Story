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
        cpos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.x + 1.5f;
        if (GetComponent<Transform>().position.x - cpos < 1.0f) {
            meet = true;
            animator.SetBool("meet_character", true);
        }
        hit = true;
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
