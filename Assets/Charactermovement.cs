using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Charactermovement : MonoBehaviour
{
    [SerializeField] public float movespeed;
    [SerializeField] public float jumpamount;

    


    void Start()
    {
        
    }

    void Update()
    {
        float moveamounthorizontal = Input.GetAxis("Horizontal")* Time.deltaTime * movespeed ;
        float moveamountvertical =  Time.deltaTime * movespeed ;

        transform.Translate(0,0,moveamountvertical);  
        transform.Translate(moveamounthorizontal,0,0);
       
        if (Input.GetAxis("Jump")!=0){
        GetComponent<Rigidbody>().velocity = new Vector3(0, jumpamount, 0);
}
       
        

    }
}
