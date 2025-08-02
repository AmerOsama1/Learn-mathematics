using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNumbers : MonoBehaviour
{
    public GameObject E;
    public NumbersManager nm;
    private bool playerInRange = false;

    // Start is called before the first frame update
    void Start()
    {
        E.SetActive(false);  // Ensure the prompt is initially inactive
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            nm.Start();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            E.SetActive(true);
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            E.SetActive(false);
            playerInRange = false;
        }
    }
}
