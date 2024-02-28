using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Charactermovement : MonoBehaviour
{
    [SerializeField] public float movespeed;
    


    void Start()
    {
        
    }

    void Update()
    {
        float moveamounthorizontal = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed ;
        float moveamountvertical = Input.GetAxis("Vertical") * Time.deltaTime * movespeed ;

        transform.Translate(0,0,moveamountvertical);  
        transform.Translate(moveamounthorizontal,0,0);
       
       
        

    }
}
