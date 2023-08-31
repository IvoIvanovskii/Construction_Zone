using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ParentingPalett : MonoBehaviour
{
    public GameObject highlight;
   

    Transform pos;
    public bool isOnLift = false;
    public GameObject Palett;
    
    
      


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Palett")  ){
            highlight.GetComponent<Outline>().enabled = false;
            isOnLift = true;
        }
    }
     private void OnTriggerStay(Collider other) {
         if(transform.position.y >= 0.85f && isOnLift ){

                 Palett.transform.SetParent(this.transform);
                //  Palett.transform.localPosition = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Palett")){
            isOnLift = false;
            highlight.GetComponent<Outline>().enabled = false;
           
        }
    }

}