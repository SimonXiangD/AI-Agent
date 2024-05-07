using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialPlayWav : MonoBehaviour
{
    public AudioSource lipAudio;
    public AudioClip[] clips;
    void Start()
    {
        
    }

    public void play() {
        stop();
        lipAudio.clip = clips[Random.Range(0,clips.Length)];
        lipAudio.Play();
    }
    
    public void stop() {
        lipAudio.Stop();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
