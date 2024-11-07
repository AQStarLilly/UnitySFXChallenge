using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDSound : MonoBehaviour
{
    public AudioSource soundtrack;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        soundtrack.Play();      
    }
}
