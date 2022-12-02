using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
   [Header("Wheels collider")]
   
   public WheelCollider frontLeftwheelcollider;
    public WheelCollider frontRightwheelcollider;
    public WheelCollider backLeftwheelcollider;
    public WheelCollider backRightwheelcollider;

    [Header("Wheels transform")]
   public Transform frontLeftwheeltransform;
    public Transform frontRightwheeltransform;
    public Transform backLeftwheeltransform;
    public Transform backRightwheeltransform;

    [Header("Car Engine")]
    public float accelerationForce = 300f;
    public float breakingForce = 3000f;
    private float presentBreakForce = 0f;
    private float presentAcceleration = 5f;


    private void update()
    {
      //  transform.Translate(Vector3.forward * Time.deltaTime * 20 * Input.GetAxis("Vertical"));
       // transform.Rotate(Vector3.up * Time.deltaTime * 20 * Input.GetAxis("Horizontal"));
    }
   
    private void MoveCar()
    {
       
        
        frontRightwheelcollider.motorTorque = presentAcceleration;
        frontLeftwheelcollider.motorTorque = presentAcceleration;
        presentAcceleration = accelerationForce * Input.GetAxis("Vertical");
    }

    private void Move()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float forwardInput = Input.GetAxis("Vertical");
        float speed = 20f;
        float turnSpeed = 45f;

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the vehicle 

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

