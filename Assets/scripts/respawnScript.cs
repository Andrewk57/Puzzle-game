using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnScript : MonoBehaviour
{
    public GameObject wbox;
    public GameObject Mbox;
    public GameObject spawn1;
    public GameObject spawn2;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Heavy Box"))
        {
            Mbox.transform.position = spawn1.transform.position;
        }
        if (collision.transform.CompareTag("Wood box"))
        {
            wbox.transform.position = spawn2.transform.position;
        }
    }
}
