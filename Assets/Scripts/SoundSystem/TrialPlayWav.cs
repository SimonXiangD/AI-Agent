using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialPlayWav : MonoBehaviour
{
    public AudioSource lipAudio;
    void Start()
    {
        
    }

    public void play() {
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
