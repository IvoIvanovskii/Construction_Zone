using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ParentingPalett : MonoBehaviour
{
    public GameObject highlight;
   

    Transform pos;
    public bool isOnLift = false;
    public GameObject Pallet;
    
    
      


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Palett")  ){
            highlight.GetComponent<Outline>().enabled = false;
            isOnLift = true;
            //parenting to trailer
            if(other.gameObject.CompareTag("Loader") ){
                Pallet.transform.parent = null;

                Pallet.transform.SetParent(this.transform);

                //putting pallet to exact possition;
                Vector3 newPosition = Pallet.transform.position;
                 newPosition.y = 2.06f; 
                Pallet.transform.position = newPosition;

            

                isOnLift = false;
            }
        }
    }
     private void OnTriggerStay(Collider other) {
         if(transform.position.y >= 0.85f && isOnLift ){

                 Pallet.transform.SetParent(this.transform);
                //  Palett.transform.localPosition = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Palett") ){
            isOnLift = false;
            Pallet.transform.parent = null;
            highlight.GetComponent<Outline>().enabled = false; 
           
        }
    }

}