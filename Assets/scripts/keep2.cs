using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keep2 : MonoBehaviour
{
    private static keep2 instance = null;
    private AudioSource audioSource;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Main")
        {
            if (this == null || this.gameObject == null || audioSource == null)
            {
                return;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
