using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float cameraSpeed = .06f;
    public float jumpForce = 5f;
    //private bool isGrounded = true;

   /* void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
        Debug.Log("Player is grounded");
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
        Debug.Log("Player left the ground");
    }*/

    void Update()
    {
        if (lavaDestroy.isLose ==false)
        {
            float translation = Input.GetAxis("Vertical") * cameraSpeed;
            float strafe = Input.GetAxis("Horizontal") * cameraSpeed;
            transform.Translate(strafe, 0, translation);
        }
        else
        {
            transform.Translate(0,0,0); 
        }
        

        /*if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }*/
    }
}