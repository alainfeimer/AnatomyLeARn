using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartPanelManager : MonoBehaviour
{

    public GameObject heartPanel;
    

    [SerializeField]
    //private Camera arCamera;
    // Start is called before the first frame update

    void Start()
    {

    }


    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            HandleInput(raycast);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            HandleInput(raycast);
        }

    }

    public void HandleInput(Ray ray)
    {
        RaycastHit raycastHit;

        if (Physics.Raycast(ray, out raycastHit))
        {
            if (raycastHit.collider.name == "heart")
            {
                OpenPanel(heartPanel);
                Debug.Log("Triggered");
            }
            else
            {
                ClosePanel(heartPanel);
            }

        }
    }


    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);

    }
}