using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Punktestand : MonoBehaviour 
{
    public static Punktestand instance; 

    public Text punkteText;
    
    public int punkte = 0;  
    
    private void Awake()
    {
        instance = this; 
    }
    
    void Start()
    {
        punkteText.text = "Dein Punktestand: " + punkte.ToString(); 
    }
    
    public void AddPoint()
    {
        punkte += 10;
        punkteText.text = "Dein Punktestand: " + punkte.ToString();
    
    }
}