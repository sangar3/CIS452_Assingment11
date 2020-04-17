using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;
    
    

    
  
    Vector3 movement;
    
   

    void Update()
    {
        ProcessInputs();

      
        Animate();
        Move();


      
       


        


        
    }

    private void Move()
    {
        transform.position = transform.position + movement * Time.deltaTime;
    }
    private void Animate()
    {
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
    }

    private void ProcessInputs()
    {
       
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        
        
    }

   

}
