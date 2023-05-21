using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_sound : MonoBehaviour
{
    public AudioSource audio;

    public void playThisSound()
    {
        audio.Play();
    }
    public void stopThisSound()
    {
        audio.Stop();
    }
}