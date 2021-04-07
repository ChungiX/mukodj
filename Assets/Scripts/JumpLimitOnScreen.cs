using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JumpLimitOnScreen : MonoBehaviour{

        public Text JumpLimit;
        void Start(){
    
        
    }

    
    void Update(){
        JumpLimit.text = "Jumps avalaible: " + Globals.JumpLimit.ToString();
        
    }
}
