using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour{

    
    
    void Start()
    {
        
    }

   
    void Update(){
        if(Globals.StaminaValue - 2 < 0){
            //Debug.Log("Can't jump, not enough Stamina");
        }
        if((Globals.JumpLimit)-1 >= 0){
            if(Input.GetKeyDown(KeyCode.Space)){
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * 450);
                Globals.StaminaValue -= 10;
                Globals.JumpLimit -= 1;
                }
        }
            //Debug.Log(canJump);
    }

       
    
    
}
