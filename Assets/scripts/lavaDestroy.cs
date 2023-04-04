using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lavaDestroy : MonoBehaviour
{
    public static bool isLose = false;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        deathScreen.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            isLose = true;


        }
        if (collision.transform.CompareTag("Wood box"))
        {
            Destroy(collision.gameObject);
            isLose = true;
        }
        if (collision.transform.CompareTag("Heavy Box"))
        {
            Destroy(collision.gameObject);
            isLose = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(isLose == true)
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
