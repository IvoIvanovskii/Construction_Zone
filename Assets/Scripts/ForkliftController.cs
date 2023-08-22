using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ForkliftController : MonoBehaviour
{
    [Header("Movement Options")]
    [SerializeField] float movementSpeed;
    [SerializeField] Vector3 rotationAxis;
    [SerializeField] float movementStick;


    float currSpeed;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
