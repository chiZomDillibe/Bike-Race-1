using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RIGHT : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public GameObject Player;
    public float Force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
         Player.transform.Translate(Force * Time.deltaTime , 0 ,0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
   {
       isPressed = true;
   }

   public void OnPointerUp(PointerEventData eventData)
   {
    isPressed = false;
   }

    

}