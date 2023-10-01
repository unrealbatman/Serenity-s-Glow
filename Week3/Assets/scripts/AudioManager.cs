using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioClip start;
    public AudioClip gameOver;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this);


        // Set up audio loop for Scene 0
        if (SceneManager.GetActiveScene().buildIndex !=3)
        {
            audioSource.clip = start;
            audioSource.loop = true;
            audioSource.Play();
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
           audioSource.Stop();
        }
        else 
        
            if(!audioSource.isPlaying)
        {
            audioSource.Play();
        }
            
        

       
    }
}
