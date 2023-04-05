using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScriptL1 : MonoBehaviour
{
    public GameObject dropPoint;
    private GameObject box;
    public GameObject saveSpot;
    public GameObject middle;
    public GameObject particle;
    public Transform spawnHere;
    public bool isParticle = false;
    public Vector3 spawnHerePos;
    public static Vector3 dropp;
    public static Vector3 mid;
    public static bool isCarrying = false;
    public AudioSource hover;
    //private Rigidbody rb;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        box = this.gameObject;
        spawnHerePos = spawnHere.transform.position;
        mid = middle.transform.position;
        //rb = this.gameObject.GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        
        if (isParticle == false)
        {
            spawnHerePos = spawnHere.transform.position;
            GameObject newObject = Instantiate(particle, spawnHerePos, Quaternion.identity);
            newObject.transform.SetParent(spawnHere);
            hover.Play();
            // spawn particle, at a position, as the child. **
            isParticle = true;
        }

        if (buttonHandleR.onButton == false)
        {
            float distance = Vector3.Distance(middle.transform.position, dropPoint.transform.position);
            //Debug.Log(distance);
            if (box.transform.position == null)
                return;
            else
            saveSpot.transform.position = box.transform.position;
            dropp=box.transform.position;
            if (dropPoint.transform.position.y <= -.1f || dropPoint.transform.position.y >= 2.87f /*|| dropPoint.transform.position.z >= 2.17f || dropPoint.transform.position.z <= -14.3f || dropPoint.transform.position.x >= -0.01f || dropPoint.transform.position.x <= -16.35f*/)
            {
                box.transform.position = saveSpot.transform.position;
                
                Debug.Log("Resetposition"); // did this so box cant be dropped through ground
            }
            else
            {
                if (wallScript.wallCollide == false)
                    box.transform.position = dropPoint.transform.position;
               
                

                

            }
            box.GetComponent<Rigidbody>().freezeRotation = true;
        }
        /* if (metalButton.onButtonMetal == false)
         {
             float distance = Vector3.Distance(middle.transform.position, dropPoint.transform.position);
             //Debug.Log(distance);
             saveSpot.transform.position = box.transform.position;
             dropp = saveSpot.transform.position;   
             if (dropPoint.transform.position.y <= -.1f || dropPoint.transform.position.y >= 2.87f || dropPoint.transform.position.z >= 2.17f || dropPoint.transform.position.z <= -14.3f || dropPoint.transform.position.x >= -0.01f || dropPoint.transform.position.x <= -16.35f)
             {
                 box.transform.position = saveSpot.transform.position;
                 Debug.Log("Resetposition"); // did this so box cant be dropped through ground
             }
              else
              {
                 if (wallScript.mallCollide == false)
                 {
                     box.transform.position = dropPoint.transform.position;
                     Debug.Log("Metal collide is false");
                 }


             }
             box.GetComponent<Rigidbody>().freezeRotation = true;
         }*/
    }
    private void OnMouseUp()
    {
        
        if (particle == null)
        {
            return;
        }
        else
            DestroyImmediate(spawnHere.GetChild(0).gameObject);
        hover.Stop();
        isParticle = false;
    }
}
