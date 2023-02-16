using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioSource buttonSound;
    private AudioSource backgroundMusic;
    private bool playMusic = true;

    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        backgroundMusic.Play();
    }

    public void OnMusicButtonClick()
    {
        if (playMusic)
        {
            backgroundMusic.Pause();
            playMusic = false;
            return;
        }
        backgroundMusic.Play();
        playMusic = true;
    }

    public void OnButtonClickSound()
    {
        buttonSound.Play();
    }
}
