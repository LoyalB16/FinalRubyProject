using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioClip musicClipThree;

    public AudioSource musicSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            musicSource.clip = musicClipThree;
            musicSource.Play();
            musicSource.loop = true;

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            musicSource.clip = musicClipThree;
            musicSource.Play();
            musicSource.loop = true;

        }
    }
}
