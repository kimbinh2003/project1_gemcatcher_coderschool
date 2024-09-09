using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource bgMusic;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Music") == 1)
        {
            SetMusic(1);
        }
        else
        {
            SetMusic(0);
        }
    }

    public void SetMusic(float volumn)
    {
        bgMusic.volume = volumn;
    }
    public void PlayAudio(AudioClip clip)
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
