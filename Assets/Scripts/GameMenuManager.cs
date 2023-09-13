using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class GameMenuManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2f;
    public GameObject menu;
    bool hasPressedButton = false;

   private void Update(){
    var device = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.LeftHand, device);
        
    if (device[0].TryGetFeatureValue(UnityEngine.XR.CommonUsages.menuButton, out bool pressed) && pressed)
    if(pressed && !hasPressedButton){
        Debug.LogError("menu appear");
        menu.SetActive(!menu.activeSelf);
        menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        hasPressedButton = true;
    }else{
        hasPressedButton = false;
    }
   
   }

}