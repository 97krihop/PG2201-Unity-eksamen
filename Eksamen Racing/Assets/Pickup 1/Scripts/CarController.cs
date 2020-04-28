using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour {
    public InputManager im;
    public List<WheelCollider> throttleWheels;
    public List<GameObject> steeringWheels;
    public List<GameObject> meshes;
    public float strengthCoefficient = 10000f;
    public float maxTurn = 20f;
    public Rigidbody rb;


    
    // Start is called before the first frame update
    void Start() {
        im = GetComponent<InputManager>();       
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        foreach (WheelCollider wheel in throttleWheels) {
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * im.throttle;
        }

        foreach (GameObject wheel in steeringWheels) {
            wheel.GetComponent<WheelCollider>().steerAngle = maxTurn * im.steer;
            wheel.transform.localEulerAngles = new Vector3(0f, im.steer * maxTurn, 0f);
        }
        //foreach (GameObject mesh in meshes) {
        //    mesh.transform.Rotate(( rb.velocity.magnitude * (transform.InverseTransformDirection(rb.velocity).z <= 0 ? 1 : -1) / (2 * Mathf.PI * 0.43), 0f, 0f);
        //}

        
       
     
        
    }


}
