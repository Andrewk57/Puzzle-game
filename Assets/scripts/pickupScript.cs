using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScript : MonoBehaviour
{
    public GameObject dropPoint;
    private GameObject box;
    public GameObject saveSpot;
    public GameObject middle;
    //private Rigidbody rb;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        box = this.gameObject;
      
        //rb = this.gameObject.GetComponent<Rigidbody>();
    }
   
    private void OnMouseDrag()
    {
        float distance = Vector3.Distance(middle.transform.position, dropPoint.transform.position);
        //Debug.Log(distance);
        saveSpot.transform.position = box.transform.position;

        if (dropPoint.transform.position.y <= -.1f || dropPoint.transform.position.y >= 3.5f || distance >= 4.6f)
        {
         box.transform.position = saveSpot.transform.position;
            Debug.Log("Resetposition"); // did this so box cant be dropped through ground
        }
        else 
        box.transform.position = dropPoint.transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
    
}
