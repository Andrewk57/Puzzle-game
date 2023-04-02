using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    //public Camera mainC;
    private float cameraSpeed = .06f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * cameraSpeed;
        float strafe = Input.GetAxis("Horizontal") * cameraSpeed;
        transform.Translate(strafe, 0, translation);
    }
}
