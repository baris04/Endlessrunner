using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Charactermovement : MonoBehaviour
{


    public enum pos {
        left, //-2
        mid, // 1 
        right // 4 

    }
    public float movespeed;
    public float jumpamount;
    bool isGrounded;
    public pos position;
    float lerpedx=1f;      
    public pos[] Currentpos = {pos.left, pos.mid , pos.right };
    int pointer;
    public float shiftroughness;









    void Start()
    {
        
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.A))
{
    pointer = Mathf.Clamp(pointer - 1, 0, 2);
    position = Currentpos[pointer];
}
     if (Input.GetKeyDown(KeyCode.D))
{
    pointer = Mathf.Clamp(pointer + 1, 0, 2);
    position = Currentpos[pointer];
}








        switch(position)
    {
        case pos.left:
            lerpedx = Mathf.Lerp(transform.position.x , -2, shiftroughness);
            transform.position = new Vector3(lerpedx, transform.position.y,transform.position.z);
            break;

        case pos.mid:
            lerpedx = Mathf.Lerp(transform.position.x , 1, shiftroughness);
            transform.position = new Vector3(lerpedx,transform.position.y,transform.position.z);
            break;

        case pos.right:
            lerpedx = Mathf.Lerp(transform.position.x , 4, shiftroughness);
            transform.position = new Vector3(lerpedx ,transform.position.y,transform.position.z);
            break;
    }

        
       // float moveamounthorizontal = Input.GetAxis("Horizontal")* Time.deltaTime * movespeed ;
        float moveamountvertical =  Time.deltaTime * movespeed ;

        transform.Translate(0,0,moveamountvertical);  
       // transform.Translate(moveamounthorizontal,0,0);
       
        if (Input.GetAxis("Jump")!=0 && isGrounded ){
        GetComponent<Rigidbody>().velocity = new Vector3(0, jumpamount, 0);
        GetComponent<Animator>().SetTrigger("Jump");
        }
    
    if(Input.GetKeyDown(KeyCode.S))
    {
        GetComponent<Animator>().SetTrigger("Crouch");
    }
       
    }

   
    
    

    void OnCollisionEnter(Collision Other)
    {
        isGrounded= true;
        GetComponent<Animator>().SetBool("isInAir",false) ;
    }
    
    void OnCollisionExit(Collision Other)
    
    {
        isGrounded= false ;
        GetComponent<Animator>().SetBool("isInAir",true) ;
    }
    }
