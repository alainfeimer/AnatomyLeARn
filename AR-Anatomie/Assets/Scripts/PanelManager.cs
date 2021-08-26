using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject quizPanel;
    // Start is called before the first frame update
    void Start()
    {
        //var welcomePanel = GameObject.Find("Panel 1 - Welcome");
        //welcomePanel.gameObject.SetActive(true);

        quizPanel = GameObject.Find("Panel 2 - Herz - Quizoption 1");
        quizPanel.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
