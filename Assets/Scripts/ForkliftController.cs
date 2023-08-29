using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ForkliftController : MonoBehaviour
{
    public ActionBasedController leftController;
    public ActionBasedController rightController;


    public Transform offset;
    public Transform steeringWheel;
    public Transform steeringWheelChild;
    public Transform maxSteerAngle;
    

    public WheelCollider FLwheel;
    public WheelCollider FRwheel;
    public WheelCollider BLwheel;
    public WheelCollider BRwheel;

    
    public Transform BLwheelTransform;
    public Transform BRwheelTransform;
    public float accelerationForce;
    public float breakForce;


    private Transform target;
    private Vector3 fromCector;
    private bool steered;
    private float angleBetween;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            target = other.transform;

            offset.position = target.position;
            offset.localPosition = new Vector3(offset.localPosition.x, 0, offset.localPosition.z);
            Vector3 dir = offset.position - transform.position;
            Quaternion rot = Quaternion.LookRotation(dir, transform.up);

            steeringWheelChild.SetParent(null);
            steeringWheel.rotation = rot;
            steeringWheelChild.SetParent(steeringWheel);
        }
    }
    
    private void  OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            target = other.transform;
        }
    }
}
