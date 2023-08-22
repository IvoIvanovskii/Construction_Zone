using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

public class MappingRotation : MonoBehaviour
{
    public Vector3 rotationAxis;
    public GameObject rotationWheel;
    public bool rotationChanged;

    Vector3 oldRotation;
    public float dir = 1;
    void Start()
    {
        rotationAxis.value = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
