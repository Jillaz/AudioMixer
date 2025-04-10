using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderHandler : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;

    private float _minSliderValue = 0.0001f;
    private float _maxSliderValue;
    private string _audioChanel = "";
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _maxSliderValue = _slider.maxValue;
        _minSliderValue += _slider.minValue;
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(SetVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(SetVolume);
    }

    public void SetAudioChanel(string chanel)
    {
        _audioChanel = chanel;
    }

    private void SetVolume(float volumeValue)
    {
        volumeValue = Mathf.Clamp(volumeValue, _minSliderValue, _maxSliderValue);
        _audioMixer.audioMixer.SetFloat(_audioChanel, Mathf.Log10(volumeValue) * 20);
    }
}
