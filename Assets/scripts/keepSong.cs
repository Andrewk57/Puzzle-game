using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepSong : MonoBehaviour
{
    private static keepSong instance = null;
    private AudioSource audioSource;
    public AudioClip newClip;

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
        if (scene.name == "L3")
        {
            audioSource.Stop();
            audioSource.clip = newClip;
            audioSource.Play();
        }
       
    }
}
