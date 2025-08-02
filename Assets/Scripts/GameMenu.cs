using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject Setting;
    public Movement mv;
    bool close =true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(close){
Setting.SetActive(true);

Cursor.visible=true;
Time.timeScale=0f;
mv.enabled=false;
close =false;
        }
        
        else{
back();
         }
        }
    }
    public void back(){
Setting.SetActive(false);
Cursor.visible=false;
Time.timeScale=1f;
mv.enabled=true;
close = true;
    }
    public void Exit(){
        Application.Quit();
    }
}
