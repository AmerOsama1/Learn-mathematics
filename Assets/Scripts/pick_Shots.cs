using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickShots : MonoBehaviour
{
    public  bool inHand = false;
    public float Range;
    public float force = 10;
    Rigidbody rb;

    public Transform Hand;
    Animator anim;
     float Firerate=.5f;
     public float Timss; 

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        inHand = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&&!inHand){
           Pick();
        }
        if(Input.GetButtonDown("Fire1")){
            Shot();
        }
    }

    public void Pick()
    {                   
        if(Time.time>Timss){

        hand();
                   Timss=Time.time+Firerate;

        }
    }
public void hand(){
        Collider[] colliders = Physics.OverlapSphere(transform.position, Range);

        foreach (Collider col in colliders)
        {
            if (col.CompareTag("pick"))
            {
                anim.SetTrigger("pick");

                col.transform.parent = this.transform;
                col.transform.position = Hand.transform.position;
                rb = col.GetComponent<Rigidbody>();
                rb.isKinematic = true;
                inHand = true;
              
      
                                               
                                    
  break; 
            }
        }
}
    public void Shot()
    {
        if (inHand )
        {
            if (rb != null)
            { 
                rb.transform.parent = null;
                rb.isKinematic = false;
                rb.velocity = transform.forward * force;
                anim.SetTrigger("drop");
                       Debug.Log("Fire1 button pressed");
                                 
                                  


            }
        }

        inHand = false;
    }
      private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    
    }
 
}
