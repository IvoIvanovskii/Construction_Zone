using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    private bool isLoaded;
   
    public GameObject Pallet;
   
   private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Palett") && other.CompareTag("Lift")){
            Pallet.transform.parent = null;

            isLoaded = true;

            
        }
   }

   private void OnTriggerStay(Collider other) {
    if(isLoaded){
         Pallet.transform.SetParent(this.transform);

            Vector3 pos = Pallet.transform.position;

            pos = new Vector3(pos.x, 2.35f, pos.z );
    }
   }
   
}
