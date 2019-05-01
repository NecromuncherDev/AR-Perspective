using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int livesLeft = 3;
    public string landingColliderTag = "BlockShadow";

    Vector3 speed = new Vector3(0, 0.01f, 0);
    Vector3 startingPos = new Vector3(0, 1, 0);
    Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        transform.SetPositionAndRotation(startingPos, transform.rotation);
        playerRB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Revive();
        }

        // If alive
        if (livesLeft > 0)
        {
            ManageMovement();
        }
    }


    private void OnCollisionEnter(Collision col)
    {
        Debug.LogWarning(col.transform.tag);

        if (col.transform.CompareTag(landingColliderTag))
        {
            ResetPlayerPosition();
        }
    }


    private void Revive()
    {
        livesLeft = 3;
    }

    private void ManageMovement()
    {
        // Go down
        if (transform.position.y == 0)
        {
        //    transform.SetPositionAndRotation(transform.position - speed, transform.rotation);
        //}
        //// Lose 1 life and return to starting location
        //else 
        //{
            livesLeft--;
            ResetPlayerPosition();
        }
        else if (transform.position.y < 0)
        {
            ResetPlayerPosition();
        }
    }

    private void ResetPlayerPosition()
    {

        transform.SetPositionAndRotation(startingPos, transform.rotation);
    }
}
