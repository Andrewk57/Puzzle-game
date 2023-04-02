using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metalButton : MonoBehaviour
{
    public GameObject plane;
    public Renderer colorRender;
    public static bool isPos2 = true;
    private float amtToGet = 2;
    public bool didDone = false;
    public static bool onButtonMetal = false;
    void Start()
    {
        colorRender = GetComponent<Renderer>();
        colorRender.material.color = Color.red;
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Heavy Box"))
        {
            //Debug.Log("Changed color with collison");
            colorRender.material.color = Color.green;
            gunHandler.amtDone++;
            onButtonMetal = true;
            if (gunHandler.amtDone >= amtToGet)
            {
                plane.transform.Translate(-15, 0, 0);
                didDone = true;
                return;
            }

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Heavy Box"))
        {
            colorRender.material.color = Color.red;
            gunHandler.amtDone--;
            /*if (gunHandler.amtDone < amtToGet && didDone == true)
            {
                Debug.Log("Set ispos2 to false");
                plane.transform.Translate(15, 0, 0);
            } */

        }

        }
    }
