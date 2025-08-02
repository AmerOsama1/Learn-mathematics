using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersManager : MonoBehaviour
{
    public int z = 80; // عدد الكائنات
    Vector3 pos;
    public Transform MainPos;
    public GameObject[] num;

    public int delay=5;

    private GameObject[] instantiatedObjects; 

    // Start is called before the first frame update
     public void Start()
    {
        instantiatedObjects = new GameObject[z]; 
        StartCoroutine(ManageNumbers());
    }

    IEnumerator ManageNumbers()
    {
        while (true)
        {
            for (int i = 0; i < z; i++)
            {
                pos = new Vector3(Random.Range(0, 5), Random.Range(0, 3), Random.Range(0, 5));
                instantiatedObjects[i] = Instantiate(num[Random.Range(0, num.Length)], MainPos.position + pos, MainPos.rotation);
            }

            yield return new WaitForSeconds(delay);

           
            for (int i = 0; i < z; i++)
            {
                Destroy(instantiatedObjects[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
