using UnityEngine;

public class SFXTuner : MonoBehaviour
{
    private const string SFXVolume = nameof(SFXVolume);

    [SerializeField] private SliderHandler _sliderHandler;

    private void Awake()
    {
        _sliderHandler.SetAudioChanel(SFXVolume);
    }
}
