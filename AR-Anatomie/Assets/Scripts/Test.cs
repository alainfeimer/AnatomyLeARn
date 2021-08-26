using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    public GameObject btn;
    
    [SerializeField]
    private Camera arCamera;

    void Update()
    {
        GameObject.Find("InfoButton").GetComponentInChildren<Text>().text = "la di da";

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
                btn.SetActive(false);
            }
            else
            {
                btn.SetActive(false);
            }

        }
    }

}