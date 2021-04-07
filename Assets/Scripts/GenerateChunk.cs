using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateChunk : MonoBehaviour{

    public GameObject DirtTile;
    public GameObject GrassTile;
    public GameObject StoneTile;
    public int width;
    public float heightMultiplier;
    public float smoothness;
    public int heightAddition;
    
    public float chancecoal;

    public GameObject CoalTile;
    public GameObject IronTile;
    public GameObject GoldTile;
    public GameObject DiamondTile;
    public GameObject ChungixTile;
    
    float seed;

    void Start(){
        seed = Random.Range(-10000f, 10000f);
        Generate();
        OreGeneration();
    
     
        
    }

    
    public void Generate(){
        for(int i = 0; i < width; i++){
            int h = Mathf.RoundToInt (Mathf.PerlinNoise (seed, i  / smoothness )* heightMultiplier )+ heightAddition;
               for(int j = 0; j < h; j++){
                GameObject SelectedTile;
                if(j < h - 4){
                    SelectedTile = StoneTile;
                } else if(j < h - 1){
                    SelectedTile = DirtTile;
                }else{
                    SelectedTile= GrassTile;
                }
                Instantiate(SelectedTile, new Vector3 (i, j), Quaternion.identity);
                
                
            }

        }
    }
    public void OreGeneration(){
            foreach(GameObject i in GameObject.FindGameObjectsWithTag("TileStone")){
                float random = Random.Range(0f, 100f);
                GameObject SelectedTile = null;

                if(random <= chancecoal){
                    SelectedTile = CoalTile;  
                    if(SelectedTile != null && i.transform.position.y > 19){
                    Instantiate(SelectedTile, i.transform.position, Quaternion.identity);}                
                }
                else if(random >= 96){
                    SelectedTile = IronTile;
                    if(SelectedTile != null && i.transform.position.y < 44 && i.transform.position.y > 10 ){
                    Instantiate(SelectedTile, i.transform.position, Quaternion.identity);}
                }
                else if(random <= 95 && random >= 94 ){
                    SelectedTile = GoldTile;
                    if(SelectedTile != null && i.transform.position.y <= 30 && i.transform.position.y >= 10){
                    Instantiate(SelectedTile, i.transform.position, Quaternion.identity);}
                } 
                else if(random <= 93 && random >= 92 ){
                    SelectedTile = DiamondTile;
                    if(SelectedTile != null && i.transform.position.y < 10 && i.transform.position.y > 0){
                    Instantiate(SelectedTile, i.transform.position, Quaternion.identity);}
                }
                else if(random <= 91.5 && random >= 91.1){
                    SelectedTile = ChungixTile;
                    if(SelectedTile != null && i.transform.position.y < 10 && i.transform.position.y > 0){
                    Instantiate(SelectedTile, i.transform.position, Quaternion.identity);}
                }                        
               
            }
        }
    
    
   
}
