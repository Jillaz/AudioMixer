using UnityEngine;

public class MusicTuner : MonoBehaviour
{
    private const string MusicVolume = nameof(MusicVolume);

    [SerializeField] private SliderHandler _sliderHandler;

    private void Awake()
    {
        _sliderHandler.SetAudioChanel(MusicVolume);
    }
}
