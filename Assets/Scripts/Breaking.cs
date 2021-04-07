 using UnityEngine;
 using System.Collections;
 
 public class Breaking : MonoBehaviour {

    

    //void OnMouseDown() {
    //     Destroy(gameObject);
    //     }
   
 

   
    void OnCollisionEnter2D(Collision2D col){
        
        if(gameObject.tag =="Grass" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.GrassCounter += 1;
                Globals.StaminaValue -= 1;
                }
         if(gameObject.tag =="Dirt" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.DirtCounter += 1;
                Globals.StaminaValue -= 1;
                }
         if(gameObject.tag =="TileStone" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.StoneCounter += 1;
                Globals.StaminaValue -= 1;
                }
         if(gameObject.tag =="Iron" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.IronCounter += 1;
                Globals.StaminaValue -= 1;
                }
         if(gameObject.tag =="Gold" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.GoldCounter += 1;
                Globals.StaminaValue -= 1;
                }
         if(gameObject.tag =="ChungiX" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.ChungiXCounter += 1;
                Globals.StaminaValue -= 1;
                }
         if(gameObject.tag =="Coal" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.CoalCounter += 1;
                Globals.StaminaValue -= 1;
                }
         if(gameObject.tag =="Diamond" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0){
                Destroy(gameObject);
                Globals.DiamondCounter += 1;
                Globals.StaminaValue -= 1;
                }




                }

        
    }
    
 