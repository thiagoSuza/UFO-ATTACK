using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioBackground;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandom();
            audioSource.Play();
        }
    }

    AudioClip GetRandom()
    {
        return audioBackground[Random.Range(0, audioBackground.Length)];
    }
}
