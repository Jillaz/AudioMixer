using UnityEngine;

public class MasterVolumeTuner : MonoBehaviour
{
    private const string MasterVolume = nameof(MasterVolume);    

    [SerializeField] private SliderHandler _sliderHandler;
    
    private void Awake()
    {
        _sliderHandler.SetAudioChanel(MasterVolume);
    }
}
