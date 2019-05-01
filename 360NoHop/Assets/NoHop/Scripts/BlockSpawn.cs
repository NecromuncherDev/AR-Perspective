using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockSpawn : MonoBehaviour
{

    [SerializeField] private Vector3 _center;
    [SerializeField]private float _radius;
    public GameObject Platform;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemy();
            Debug.Log("you did the thing");
        }
    }




    public void SpawnEnemy()
    {
        var platform = Instantiate(Platform, transform);
        platform.transform.position = GetRandomPosition();
        float change = Mathf.Atan2(platform.transform.position.z , platform.transform.position.x);
        change = change * (180 / Mathf.PI);
        Debug.LogWarning(change+" x:"+platform.transform.position.x+" y:"+ platform.transform.position.z); 
       
        platform.transform.Rotate(0,-change, 0);
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 point = Random.insideUnitCircle.normalized * _radius;

        point.z = point.y;
        point.y = _center.y;

        return _center + point;
    }

   
}
