using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTouch : MonoBehaviour
{
    bool isOpen = false;
    string trackedImageName = "lung";
        

    // Update is called once per frame
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
            if (raycastHit.collider != null)
            {
                //OpenPanel(beePanel);
                GUI.Label(new Rect(0, 0, 100, 100), "Some Random Text");
                Debug.Log("Test");
            }
            else
            {
                //ClosePanel(beePanel);
            }

        }
    }

    void getTrackedImage()
    {
        //trackedImageName = ImageTrackerManager.getTrackedImage.name;
    }

     
    }


