using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHandleR : MonoBehaviour
{
    public GameObject plane;
    public Renderer colorRender;
    public static float amtDone = 0;
    private float amtToGet = 1;
    void Start()
    {
     colorRender = GetComponent<Renderer>();
    }

   
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Heavy Box"))
        {
            //Debug.Log("Changed color with collison");
            colorRender.material.color = Color.green;
            amtDone++;
            if (amtDone >= amtToGet)
            {
                plane.transform.Translate(-15, 0, 0);
            }

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Heavy Box"))
        {
            colorRender.material.color = Color.red;
            amtDone--;
            if (amtDone < amtToGet)
            {
                plane.transform.Translate(15, 0, 0);
            }
            
        }

    }
    private void Update()
    {
       
        
            

    }

}
