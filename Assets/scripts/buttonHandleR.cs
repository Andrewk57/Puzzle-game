using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHandleR : MonoBehaviour
{
    public GameObject plane;
    public Renderer colorRender;
    public static bool isPos = true;
    private float amtToGet = 2;
    public bool didDone=false;
    public static bool onButton = false;
    public AudioSource ding;
    void Start()
    {
     colorRender = GetComponent<Renderer>();
        colorRender.material.color = Color.red;
    }

   
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wood box"))
        {
            //Debug.Log("Changed color with collison");
            colorRender.material.color = Color.green;
            ding.Play();
            gunHandler.amtDoneTut++;
            //collision.rigidbody.isKinematic = true;
            onButton = true;
            if (gunHandler.amtDoneTut >= amtToGet)
            {
                plane.transform.Translate(-15, 0, 0);
                didDone = true;
            }

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wood box"))
        {
            colorRender.material.color = Color.red;
            onButton = false;
            gunHandler.amtDoneTut--;
            if (gunHandler.amtDoneTut < amtToGet&& didDone==true)
            {
                Debug.Log("Set ispos to false");
                
                plane.transform.Translate(15, 0, 0);
            }
            
        }

    }
    private void Update()
    {
       
        
            

    }

}
