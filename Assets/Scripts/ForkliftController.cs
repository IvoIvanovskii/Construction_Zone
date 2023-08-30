using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ForkliftController : MonoBehaviour
{
    float wheelRotation;
    float movementSpeed = 2;
    public void UpdateWheelRotation(float val){
        wheelRotation = (val - 0.5f) * 2f * 45;
        
    } 

    private void FixedUpdate() {
        var device = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.RightHand, device);

        //Moving forwards
        if (device[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton, out bool pressed) && pressed)
        {
           if(pressed){
                // GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(0, wheelRotation,0));
                transform.position += transform.forward * Time.deltaTime * movementSpeed;
                // GetComponent<Rigidbody>().MovePosition( new Vector3(0, 0, transform.localPosition.z + movementSpeed * Time.deltaTime));
                // transform.localPosition = new Vector3(0, 0, transform.localPosition.z + movementSpeed * Time.deltaTime);
               
           }
        } else if(device[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.secondaryButton, out bool Rpressed) && Rpressed)
           {
                if(Rpressed){
                transform.position -= transform.forward * Time.deltaTime * movementSpeed;
                }
           }
            transform.localRotation = Quaternion.Euler(0, wheelRotation,0);
        
        
    }
}
