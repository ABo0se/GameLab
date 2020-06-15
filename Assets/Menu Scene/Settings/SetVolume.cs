using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer audioMixer;
    private void Start()
    {
        audioMixer.SetFloat("MusicVol", Mathf.Log10(0.0625f)*30);
    }
    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("MusicVol", (Mathf.Log10(0.00125f + (volume / 8))) * 30);
    }
}