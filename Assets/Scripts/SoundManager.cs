using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource goodSoundAS;
    public AudioSource badSoundAS;

    AudioSource fluteAudioSource;

    public void PlayGoodSound()
    {
        Debug.Log("played note");
        goodSoundAS.Play();
    }

    public void PlayBadSound()
    {
        Debug.Log("played no note");
        badSoundAS.Play();
    }

    public void PlaySound(AudioClip sound)
    {
        fluteAudioSource.clip = sound;
        fluteAudioSource.Play();
    }
}
