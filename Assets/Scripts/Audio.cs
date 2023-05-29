using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    public Toggle MusicToggle;
    public Toggle SoundToggle;

    public void ToggleMusic()
    {
        if (MusicToggle.isOn)
            Mixer.audioMixer.SetFloat("MusicVolume", -80);
        else
            Mixer.audioMixer.SetFloat("MusicVolume", 0);
    }

    public void ToggleSounds()
    {
        if (SoundToggle.isOn)
            Mixer.audioMixer.SetFloat("SoundVolume", 0);
        else
            Mixer.audioMixer.SetFloat("SoundVolume", -80);
    }

}
