using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LifterUPDown : MonoBehaviour
{
    [SerializeField] Transform liftTransfrom;


    [SerializeField] Vector2 minLiftPosition;
    [SerializeField] Vector2 maxLiftPosition;


    //shows the speed of the lifter with and without the palett
    [SerializeField] float liftWithoutPalett;
    [SerializeField] float liftWithPalett;
    

    
    Vector2 joystickValue;

    void UpdateLiftPosition(float speed){
        var liftPosition = liftTransfrom.localPosition;

        liftPosition += new Vector3(joystickValue.x * speed * Time.deltaTime, 0f, joystickValue.y * speed * Time.deltaTime);            

        liftPosition.x = Mathf.Clamp(liftPosition.x, minLiftPosition.x, maxLiftPosition.x);
        liftPosition.y = Mathf.Clamp(liftPosition.y, minLiftPosition.y, maxLiftPosition.y);


        liftTransfrom.localPosition = liftPosition;
    }

public void OnJoystickValueChangeX(float x){
        joystickValue.x = x;
    }
    public void OnJoystickValueChangeY(float y){
        joystickValue.y = y;
    }
}