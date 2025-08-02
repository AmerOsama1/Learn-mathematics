using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equation : MonoBehaviour
{
    AudioSource sr;
    public Sprite[] sp; // Array of sprites for numbers
    public int x; 
    public Image xImage;
    public int y;
    public Image yImage;
    public int z;
    public Image zImage;
public AudioClip WrongClip,correctClip;
    int min = 0;
    int max = 10;

public Points pp;
    // Start is called before the first frame update
    void Start()
    {
        sr=GetComponent<AudioSource>();
        ChangeNumbers(); 
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Correct();
        }
    }

    void Correct()
    {
        if (x + y == z)
        {
            ChangeNumbers();
            increasePoints();
        }
        else
        {
            deCreasePoints();
            ChangeNumbers();
        }
    }

    void ChangeNumbers()
    {
        x = Random.Range(min, max);
        y = Random.Range(min, max);
        z=0;

        xImage.sprite = sp[x];
        yImage.sprite = sp[y];

    }
    void increasePoints(){
        sr.clip=correctClip;
        pp.point++;
        sr.PlayOneShot(correctClip);
    }
    void deCreasePoints(){
                pp.point--;
                sr.clip=WrongClip;
                        sr.PlayOneShot(WrongClip);


    }
}
