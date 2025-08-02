using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 6f;
    public Transform camera;
    public float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    private Animator anim;

    private Vector3 movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        anim = GetComponent<Animator>();

        Cursor.visible = false; 
    }

    void Update()
    {
 
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        movementInput = new Vector3(x, 0f, z).normalized;

      
        bool isWalking = movementInput.magnitude >= 0.1f;
        anim.SetBool("walk", isWalking);
    }

    void FixedUpdate()
    {
        if (movementInput.magnitude >= 0.1f)
        {
         
            float targetAngle = Mathf.Atan2(movementInput.x, movementInput.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

         
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.MovePosition(rb.position + moveDir.normalized * speed * Time.fixedDeltaTime);
        }
    }
}
