using UnityEngine;
using UnityEngine.Audio;

public class SoundTuner : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;
    private float minVolume = -80f;
    private float maxVolume = 0f;
    private bool isSoundEnabled = true;

    public void ToggleSounds(bool isMuted)
    {
        if (isMuted)
        {
            _audioMixer.audioMixer.SetFloat("MasterVolume", minVolume);
        }
        else
        {
            _audioMixer.audioMixer.SetFloat("MasterVolume", Mathf.Log10(maxVolume) * 20);
        }

        isSoundEnabled = !isMuted;
    }

    public void SetMasterVolume(float volumeValue)
    {
        volumeValue = Mathf.Clamp(volumeValue, 0.0001f, 1f);
        maxVolume = volumeValue;

        if (isSoundEnabled)
        {
            _audioMixer.audioMixer.SetFloat("MasterVolume", Mathf.Log10(volumeValue) * 20);
        }
    }

    public void SetMusicVolume(float volumeValue)
    {
        volumeValue = Mathf.Clamp(volumeValue, 0.0001f, 1f);
        _audioMixer.audioMixer.SetFloat("MusicVolume", Mathf.Log10(volumeValue) * 20);
    }

    public void SetSFXVolume(float volumeValue)
    {
        volumeValue = Mathf.Clamp(volumeValue, 0.0001f, 1f);
        _audioMixer.audioMixer.SetFloat("SFXVolume", Mathf.Log10(volumeValue) * 20);
    }
}
