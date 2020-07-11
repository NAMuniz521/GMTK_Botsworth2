using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform lookAtTarget;


    public Transform camTransform;
    public Vector3 camPosition;
    public Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = GetComponent<Transform>();
        camPosition = GetComponent<Transform>().position;

        cameraOffset = camPosition - lookAtTarget.position;
    }

    
    private void FixedUpdate()
    {
        camTransform.position = lookAtTarget.position + cameraOffset;  
    }
}
