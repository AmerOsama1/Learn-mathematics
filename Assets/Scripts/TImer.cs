using UnityEngine;
using TMPro;

public class TImer : MonoBehaviour
{
    public float Timer;
    public TextMeshProUGUI TimeText;
public GameObject Lo;
    void Update()
    {
   
        
            Timer -= Time.deltaTime;
            int min=Mathf.FloorToInt(Timer/60);
            int sec=Mathf.FloorToInt(Timer%60);
        

        TimeText.text =string.Format("{0:00}:{1:00}",min,sec) ;

        if (Timer <= 0)
        {
            Lose();
        }
    }

    void Lose()
    {
        Time.timeScale = 0f;
        Lo.SetActive(true);
    }
   
}
