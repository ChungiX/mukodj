using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
     
     public int DelayAmount = 3;
     public int JumpDelayAmount = 1; 
    
     protected float Timer;
     
     void Update()
     {
         Timer += Time.deltaTime;
 
         if (Timer >= DelayAmount && Globals.StaminaValue <= 30)
         {
             Timer = 0f;
             Globals.StaminaValue += 4; // For every DelayAmount or "second" it will add one to the GoldValue
             Debug.Log(Globals.StaminaValue);
            
         }
         if(Globals.StaminaValue < 0){
             Globals.StaminaValue = 0;
         }
         if(Globals.StaminaValue >30){
             Globals.StaminaValue = 30;
         }
        
         
        Timer += Time.deltaTime;
         if (Timer >= JumpDelayAmount && Globals.JumpLimit < 2)
         {
             Timer = 0f;
             Globals.JumpLimit += 1; 


        
             
            
         }






     }

}
