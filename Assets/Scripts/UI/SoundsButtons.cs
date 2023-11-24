using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsButtons : MonoBehaviour
{
    public AudioSource sound;

    public AudioClip soundLogo;
    public AudioClip soundAntMarcha;
    public AudioClip soundSigtMarcha;
    public AudioClip soundLaser;
    public AudioClip soundEspada;

    public AudioClip soundDenied;

    public void SoundLogo(){
        sound.clip = soundLogo;

        sound.enabled = false;
        sound.enabled = true;
    }

    public void SoundAntMarcha(){
        sound.clip = soundAntMarcha;

        sound.enabled = false;
        sound.enabled = true;
    }

    public void SoundSigMarcha(){
        sound.clip = soundSigtMarcha;

        sound.enabled = false;
        sound.enabled = true;
    }

    public void SoundLaser(){
        sound.clip = soundLaser;

        sound.enabled = false;
        sound.enabled = true;
    }

    public void SoundEspada(){
        sound.clip = soundEspada;

        sound.enabled = false;
        sound.enabled = true;
    }

     public void SoundDenied(){
        sound.clip = soundDenied;

        sound.enabled = false;
        sound.enabled = true;
    }
}
