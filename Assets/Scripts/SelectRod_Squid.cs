using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRod_Squid : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chooseCharacter(int index){
        PlayerPrefs.SetInt("Character",index); // 1 girl   2 boy 
    }
}
