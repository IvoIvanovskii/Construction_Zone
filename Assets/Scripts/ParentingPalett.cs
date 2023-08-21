using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentingPalett : MonoBehaviour
{
    Transform pos;
    public bool isOnLift = false;
    public GameObject Palett;


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Palett")){
            
            isOnLift = true;
        }
    }
     private void OnTriggerStay(Collider other) {
         if(transform.position.y >= 0.85f && isOnLift){
           
                 Palett.transform.SetParent(this.transform);
                //  Palett.transform.localPosition = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Palett")){
            isOnLift = false;
        }
    }
}
