using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePanel : MonoBehaviour
{
    public GameObject Panel;

    void close()
    {
        Panel.SetActive(false);
    }
    
    
}
