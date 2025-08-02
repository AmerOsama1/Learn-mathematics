using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    private string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Select(string level)
    {
        levelToLoad = level;
        Invoke("ChangeLevel", 1f); // Delays the ChangeLevel method by seconds
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
