using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentingPalett : MonoBehaviour
{

    public bool isOnLift = false;
    public GameObject Palett;


 private void Update() {
    if(isOnLift){
        Palett.transform.SetParent(this.transform);
    } else {
        Palett.transform.SetParent(null);
    }
}
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Palett")){
            isOnLift = true;
        }
    }
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("Palett")){
            isOnLift = false;
        }
    }
}
