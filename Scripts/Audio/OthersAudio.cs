using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OthersAudio : MonoBehaviour
{
    public static OthersAudio instance;
    public AudioClip[] explosion,pickup,especial;
    public AudioClip crystalCollected,missil;
    public AudioSource audioPlay;

    private void Awake()
    {
        instance = this;
    }
    
    

    public void explosionSound()
    {
        int x = Random.Range(0, explosion.Length);
        audioPlay.PlayOneShot(explosion[x]);
    }

    public void PickUpSound()
    {
        int x = Random.Range(0, pickup.Length);
        audioPlay.PlayOneShot(pickup[x]);
    }

    public void CrystalSound()
    {
        audioPlay.PlayOneShot(crystalCollected);
    }
    public void MissilSound()
    {
        audioPlay.PlayOneShot(missil);
    }

    public void SpecialSound()
    {
        int x = Random.Range(0, especial.Length);
        audioPlay.PlayOneShot(especial[x]);
    }
}
