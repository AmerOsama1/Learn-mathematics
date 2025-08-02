using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public float Range = 5f ;
    public Vector3 pos;
    public int MyNumber;
    public Equation eq;
    bool check=false;
    PickShots sh;
    // Start is called before the first frame update
    void Start()
    {
        eq=GameObject.FindGameObjectWithTag("Eq").GetComponent<Equation>();
                sh=GameObject.FindGameObjectWithTag("player").GetComponent<PickShots>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(check&&Input.GetKeyDown(KeyCode.Space)){
            Destroy(gameObject);
            
        }
         Collider[] colliders = Physics.OverlapSphere(transform.position, Range);

        foreach (Collider col in colliders)
        {
           
             if (col.CompareTag("stageZ"))
            {transform.position = col.transform.position + pos ;
            
            eq.z=MyNumber;
            check=true;
            sh.inHand=false;
            }
    }
}
  private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    
    }
}