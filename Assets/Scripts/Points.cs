using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{    public TextMeshProUGUI PointText;

    public int point=0;
    public GameObject WinScreen;
    public Movement mv;
    public int WinPoint= 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PointText.text=point.ToString();
        win ();
       
    }
    void win (){
        if(point>=WinPoint){
            Debug.Log("w");
            WinScreen.SetActive(true);
            Time.timeScale=0f;
            Cursor.visible=true;
            mv.enabled=false;
        }
    }
}
