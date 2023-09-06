using UnityEngine;

public class LifterUPDown : MonoBehaviour
{
    [SerializeField] Transform liftTransfrom;

    public void OnJoystickValueChangeX(float x) => liftTransfrom.localPosition =  new Vector3( Mathf.Lerp(0.53f, -0.53f, x), liftTransfrom.localPosition.y, liftTransfrom.localPosition.z);
    public void OnJoystickValueChangeY(float y) => liftTransfrom.localPosition =  new Vector3(liftTransfrom.localPosition.x, Mathf.Lerp(0.85f, 2.93f, y), liftTransfrom.localPosition.z);
    
}