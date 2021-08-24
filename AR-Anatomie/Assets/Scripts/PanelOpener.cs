using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public bool panelActive;

    public void openPanel()
    {
        if(Panel != null && panelActive == false)
        {
            Panel.SetActive(true);
            panelActive = true;
            GameObject.Find("InfoButton").GetComponentInChildren<Text>().text = "Fakt ausblenden";
        } 
        
        else if (panelActive == true)
        {
            Panel.SetActive(false);
            panelActive = false;
            GameObject.Find("InfoButton").GetComponentInChildren<Text>().text = "Fakt einblenden";
        }
    }

}
