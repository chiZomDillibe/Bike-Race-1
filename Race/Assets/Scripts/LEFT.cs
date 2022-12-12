using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class LEFT : MonoBehaviour,IPointerDownHandler, IPointerUpHandler

{
    bool isPressed = false;
    public GameObject Player;
    public float Force;
    public float turnSpeed = -25.0f;

    public void StartGame(int difficulty)
    {
        Force = Force * difficulty;
        turnSpeed = turnSpeed * difficulty;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
         
            // We move the vehicle forward
            Player.transform.Translate(Vector3.forward * Time.deltaTime * Force);


            // We turn the vehicle 
            Player.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
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
