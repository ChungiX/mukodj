using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTF : MonoBehaviour
{
   public GameObject shopcanvas;
   

    void Update()
    {
        if(Input.GetKey("t")){
            Globals.Activated = true;
        }
        if(Input.GetKeyDown("escape")){
            Globals.Activated = false;
        }
            
        if(Globals.Activated == true){
            shopcanvas.SetActive(true);
        }else{
            shopcanvas.SetActive(false);
        }
        
    }
}
