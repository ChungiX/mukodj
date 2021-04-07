using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOnClick : MonoBehaviour
{   
        
     void Update(){
        if(Input.GetMouseButtonDown(0)){
             Vector2 mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
             RaycastHit2D hit = Physics2D.Raycast(mousePos,Vector2.zero, 100f);   
                if(hit.collider != null){
                
                    if(hit.collider.gameObject.tag =="Grass" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false ){
                            Destroy(hit.collider.gameObject);
                            Globals.GrassCounter += 1;
                            Globals.StaminaValue -= 1;
                            }
                    if(hit.collider.gameObject.tag =="Dirt" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false){
                            Destroy(hit.collider.gameObject);
                            Globals.DirtCounter += 1;
                            Globals.StaminaValue -= 1;
                            }
                    if(hit.collider.gameObject.tag =="TileStone" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false){
                            Destroy(hit.collider.gameObject);
                            Globals.StoneCounter += 1;
                            Globals.StaminaValue -= 1;
                            }
                    if(hit.collider.gameObject.tag =="Iron" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false){
                            Destroy(hit.collider.gameObject);
                            Globals.IronCounter += 1;
                            Globals.StaminaValue -= 1;
                            }
                    if(hit.collider.gameObject.tag =="Gold" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false){
                            Destroy(hit.collider.gameObject);
                            Globals.GoldCounter += 1;
                            Globals.StaminaValue -= 1;
                            }
                    if(hit.collider.gameObject.tag =="ChungiX" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false){
                            Destroy(hit.collider.gameObject);
                            Globals.ChungiXCounter += 1;
                            Globals.StaminaValue -= 1;
                            }
                    if(hit.collider.gameObject.tag =="Coal" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false){
                            Destroy(hit.collider.gameObject);
                            Globals.CoalCounter += 1;
                            Globals.StaminaValue -= 1;
                            }
                    if(hit.collider.gameObject.tag =="Diamond" && Input.GetMouseButton(0) && (Globals.StaminaValue-1)>=0 && Globals.Activated == false){
                            Destroy(hit.collider.gameObject);
                            Globals.DiamondCounter += 1;
                            Globals.StaminaValue -= 1;
                            }




                        }

                
            }
     }
    }

