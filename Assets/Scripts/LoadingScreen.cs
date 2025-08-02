using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingScreen : MonoBehaviour
{
    public float waitTime= 4f;
    // Start is called before the first frame update
    void Start()
    {
      Invoke("ChangeScreen",waitTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeScreen(){
        SceneManager.LoadScene("Main");
    }
}
