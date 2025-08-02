using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    int Number;
    public GameObject[] character;
    public Transform sp;
    // Start is called before the first frame update
    void Start()
    {
     Number=  PlayerPrefs.GetInt("Character") ;
     Instantiate(  character[Number],sp.position,sp.rotation);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
