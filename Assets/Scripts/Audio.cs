using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Text.RegularExpressions;

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

    public void SliderMusic(float m_Value)
    {
        Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, m_Value));
    }
    public void SliderSounds(float m_Value)
    {
        Mixer.audioMixer.SetFloat("SoundVolume", Mathf.Lerp(-80, 0, m_Value));
    }

}
