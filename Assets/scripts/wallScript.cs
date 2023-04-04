using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour
{
    public GameObject Wbox;
    public GameObject saveSpotWall;
    public GameObject Mbox;
    public float mag;
    public static bool reEnable = false;
    public static bool wallCollide = false; 
    public static bool mallCollide = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wood box"))
        {
            wallCollide = true;
            Debug.Log("Hit wall");
            Wbox.transform.position = pickupScriptL1.dropp;
            Debug.Log("Should of set dwon fr");

          

        }

        if (collision.transform.CompareTag("Heavy Box"))
        {
            mallCollide = true;
            Mbox.transform.position = pickupScriptL1.dropp;


            
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Wood box"))
        {
            wallCollide = false;

        }
        if (collision.transform.CompareTag("Heavy Box"))
         {

             mallCollide = false;

         }
            
        }
    }

