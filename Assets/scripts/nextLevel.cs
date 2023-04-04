using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public string LevelNext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gunHandler.amtDoneTut = 0;
            buttonHandleR.onButton = false;
            metalButton.onButtonMetal = false;
            SceneManager.LoadScene(LevelNext);
        }
    }
    void Update()
    {
        
    }
}
