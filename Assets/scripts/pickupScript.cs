using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScript : MonoBehaviour
{
    public GameObject dropPoint;
    private GameObject box;
    public GameObject saveSpot;
    public GameObject middle;
    public GameObject particle;
    public Transform spawnHere;
    public bool isParticle = false;
    public Vector3 spawnHerePos;
    public float distanceHolderReg;
    public float distanceHolderMetal;
    public AudioSource hover;
    
    //private Rigidbody rb;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        box = this.gameObject;
        spawnHerePos= spawnHere.transform.position;
        //rb = this.gameObject.GetComponent<Rigidbody>();
    }
   
    private void OnMouseDrag()
    {
        if (isParticle == false)
        {
            spawnHerePos = spawnHere.transform.position;
            GameObject newObject = Instantiate(particle, spawnHerePos, Quaternion.identity);
            newObject.transform.SetParent(spawnHere);
            //play audio clip here
            hover.Play();
             // spawn particle, at a position, as the child. **
            isParticle = true;
        }
        
        if (buttonHandleR.onButton == false)
        {
            float distance = Vector3.Distance(middle.transform.position, dropPoint.transform.position);
            //distanceHolderReg = distance; // debug
            saveSpot.transform.position = box.transform.position;

            if (dropPoint.transform.position.y <= -.1f || dropPoint.transform.position.y >= 3.5f || distance >= 4.6f)
            {
                box.transform.position = saveSpot.transform.position;
                Debug.Log("Resetposition"); // did this so box cant be dropped through ground
            }
            else
            {
                box.transform.position = dropPoint.transform.position;
            }
            box.GetComponent<Rigidbody>().freezeRotation = true;
        }
        if (metalButton.onButtonMetal == false)
        {
            float distance = Vector3.Distance(middle.transform.position, dropPoint.transform.position);
            //distanceHolderMetal = distance; //debug
           // Debug.Log(distance);
            saveSpot.transform.position = box.transform.position;

            if (dropPoint.transform.position.y <= -.1f || dropPoint.transform.position.y >= 3.5f || distance >= 4.6f)
            {
                box.transform.position = saveSpot.transform.position;
                Debug.Log("Resetposition"); // did this so box cant be dropped through ground
            }
            else
            {
                box.transform.position = dropPoint.transform.position;
            }
            box.GetComponent<Rigidbody>().freezeRotation = true;
        }
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
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(distanceHolderReg);

    }
    
}
