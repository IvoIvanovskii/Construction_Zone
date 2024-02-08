using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class AutomaticDoor : MonoBehaviour
{
   public Vector3 endPos;
   public float speed = 1.0f;


   private bool moving = false;
   private bool oppening = true;
   private Vector3 startPos;
   private float delay = 0.0f;

    private void Start() {

        startPos = transform.position;

    }

    private void Update() {
        if(moving) {
            if(oppening) {
            
                MoveDoor(endPos);
            }
            else{
                MoveDoor(startPos);
            }
        }
    }
    void MoveDoor(Vector3 goalPos){

        float dist = Vector3.Distance(transform.position, goalPos);
        if(dist > .1f){
            transform.position = Vector3.Lerp(transform.position, goalPos, speed * Time.deltaTime);
        }
        else{
            if(oppening){

                delay += Time.deltaTime;
                if(delay > 15.0f){
                    oppening = false;
                }
            }
            else {

                moving = false;
                oppening = true;
            }
        }
    }

    public bool Moving{

        get {return moving;}
        set {moving = value;}

    }

   }
