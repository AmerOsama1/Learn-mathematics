using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    AudioSource sr;
    // public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        sr=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit(){
        Application.Quit();
    }
    public void StartSound(AudioClip clip){
        sr.clip=clip;
        sr.PlayOneShot(clip);
    }
}
