using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ChangeSceneWithButton : MonoBehaviour
{
    private GameObject welcomePanel;
   public void LoadScene(string sceneName)
    {
        
        
        if(sceneName == "SampleScene")
        {
            LoaderUtility.Deinitialize();
            SceneManager.LoadScene(sceneName);
            LoaderUtility.Initialize();
            
        } else
        {
            /**welcomePanel = GameObject.Find("Panel 1 - Welcome");
            welcomePanel.gameObject.SetActive(false);

            var quizPanel = GameObject.Find("Panel 2 - Herz - Quizoption 1");
            quizPanel.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;**/

            SceneManager.LoadScene(sceneName);
        }
    }
}
