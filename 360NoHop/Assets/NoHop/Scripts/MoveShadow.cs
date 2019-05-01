using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShadow : MonoBehaviour
{
    [SerializeField] Transform headPosision;


    private void Update()
    {
        headPosision = Camera.main.transform;
        transform.GetComponent<Collider>().transform.SetPositionAndRotation(transform.position, headPosision.rotation);  
    }
}
