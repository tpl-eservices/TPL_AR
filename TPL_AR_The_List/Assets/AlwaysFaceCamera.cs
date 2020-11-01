using UnityEngine;
using System.Collections;
 
public class AlwaysFaceCamera : MonoBehaviour
{
    public Camera referenceCamera;

    void Awake()
    {
        // if no camera referenced, grab the main camera
        if (!referenceCamera)
            referenceCamera = Camera.main;
    }
    //Orient the camera after all movement is completed this frame to avoid jittering
    void LateUpdate()
    {
        transform.LookAt(transform.position + referenceCamera.transform.rotation * Vector3.forward,
            referenceCamera.transform.rotation * Vector3.up);
    }
}
