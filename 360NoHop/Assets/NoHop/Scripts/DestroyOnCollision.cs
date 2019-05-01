using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        Debug.LogWarning("Collision with '" + col.gameObject.name + "' detected");
        if (col.transform.CompareTag("Player"))
        {
            foreach (Transform c in transform)
            {
                Debug.Log("Child: " + c.name);
                if (c.name == "Cube(Clone)")
                {
                    Destroy(c.gameObject);
                }
            }

            this.GetComponent<BlockSpawn>().SpawnEnemy();
        }
        //Destroy(gameObject);
    }
}
