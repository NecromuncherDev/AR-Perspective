using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShadow : MonoBehaviour
{
    Transform cameraTransform;
    float yRotation;

    private void Update()
    {
        cameraTransform = Camera.main.transform;
        yRotation = cameraTransform.eulerAngles.y;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation + 90, transform.eulerAngles.z);  
    }
}
