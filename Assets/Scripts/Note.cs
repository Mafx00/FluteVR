using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Note : MonoBehaviour
{
    public string noteName;
    public List<int> holes;
    public GameObject visualizer;
    //public AudioClip sound;
    public void OnPlayed()
    {
        SoundManager.instance.PlayGoodSound();
        visualizer.SetActive(true);
    }
    public void OnStopPlay()
    {
        visualizer.SetActive(false);
    }
}
