using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour{
    
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    //public float speed;
    
    void Update(){
       // float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        //float y = Input.GetAxis("Vertical")*Time.deltaTime*speed;

        //transform.Translate(x,0,0);
        Input.GetAxisRaw("Horizontal");
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump")){
            jump = true;
            
        }
        
    }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    
}
