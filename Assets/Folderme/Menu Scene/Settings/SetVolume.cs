using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    private int firstplayor;
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    public Slider backgroundSlider;
    private float backgroundFloat;
    public AudioMixer audioMixer;
    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectsAudio;
    private void Start()
    {
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundSlider.value = backgroundFloat;
        }
    }
    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
    }
    private void OnApplicationFocus(bool infocus)
    {
        if (!infocus)
            SaveSoundSettings();
    }
    public void UpdateSound()
    {
        backgroundAudio.volume = backgroundSlider.value;
        backgroundSlider.value = backgroundFloat;
    }
}