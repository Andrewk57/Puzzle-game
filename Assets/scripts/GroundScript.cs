using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public static bool isGrounded = false;
    public GameObject wbox;
    public GameObject Mbox;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wood box"))
        {

            isGrounded = true;
            Debug.Log("OnFloor");
        }
        if (collision.transform.CompareTag("Heavy Box"))
        {
            isGrounded = true;
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Wood box"))
        {
            isGrounded = false;
            Debug.Log("Off floor");
        }
        if (collision.transform.CompareTag("Heavy Box"))
        {
            isGrounded = false;
        }
    }

}
