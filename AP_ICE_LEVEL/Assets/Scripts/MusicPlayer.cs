using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip;  // The music clip to play
    public bool playOnAwake = true;  // Whether to start playing the music when the game starts

    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to this game object
        audioSource = GetComponent<AudioSource>();

        // Set the music clip and whether to play on awake
        audioSource.clip = musicClip;
        audioSource.playOnAwake = playOnAwake;
    }

    public void Play()
    {
        // Start playing the music
        audioSource.Play();
    }

    public void Pause()
    {
        // Pause the music
        audioSource.Pause();
    }

    public void Stop()
    {
        // Stop the music
        audioSource.Stop();
    }
}

