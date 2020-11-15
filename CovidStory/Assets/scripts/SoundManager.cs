using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip hitsound1;
    AudioSource myAudio;
    public static SoundManager instance; 
    void Awake() 
    {
        if (SoundManager.instance == null)
        {
            SoundManager.instance = this; 
        }
    }
    void Start()
    {
        myAudio = this.gameObject.GetComponent<AudioSource>();
    }
    public void hitSound(){
        myAudio.PlayOneShot(hitsound1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
