using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sound : MonoBehaviour
{
    float x ;
    public Slider sl;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume",1);
        }
        else{
            load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void change(float x){
x=sl.value;
        AudioListener.volume=x;
        save();
    }
    public void load(){
     x =   PlayerPrefs.GetFloat("musicVolume");
    }
    public void save(){
    PlayerPrefs.SetFloat ("musicVolume",x);
}}
