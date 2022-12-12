using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour, IPointerClickHandler
{
   
        //Detect if a click occurs
        public void OnPointerClick(PointerEventData pointerEventData)
        {
            
           // UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    

    // Update is called once per frame
    void Update()
    {
        
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
           
        }
    }
}
