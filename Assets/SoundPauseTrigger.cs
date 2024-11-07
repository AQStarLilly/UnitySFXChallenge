using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPauseTrigger : MonoBehaviour
{
    public AudioSource soundtrack;
    // Start is called before the first frame update
    
    private void  OnTriggerEnter(Collider other)
    {
        if(soundtrack.isPlaying)
        {
            soundtrack.Pause();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(!soundtrack.isPlaying)
        {
            soundtrack.UnPause();
        }
    }
}
