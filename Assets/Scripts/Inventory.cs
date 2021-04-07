using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour{

        public Text inventoryText;
        int[] counts = new int[8];
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { inventoryText.text="Grass: " + Globals.GrassCounter + "\nDirt: " + Globals.DirtCounter + "\nStone: " + Globals.StoneCounter + "\nIron: " + Globals.IronCounter + "\nGold: " + Globals.GoldCounter + "\nChungiX: "+ Globals.ChungiXCounter + "\nCoal: "+ Globals.CoalCounter + "\nDiamond: " + Globals.DiamondCounter;
        
       
    }

}
