using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenyManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2f;
    public GameObject menu;
    public InputActionProperty showButton;

   private void Update() {
    if(showButton.action.WasPressedThisFrame()){
        menu.SetActive(menu.activeSelf);

        menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        
    }
   }

}
