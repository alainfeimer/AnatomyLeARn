using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PunktestandAnzeige : MonoBehaviour {
    
    private int punkte = 20;
    public Text punkteText; 
    
    void Update(){
        
        punkteText.text = "Punktestand:" + punkte;
        
        if(Input.GetKeyDown(KeyCode.Space)){
            punkte--;
        }
    }
}
