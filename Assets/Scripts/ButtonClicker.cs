using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class ButtonClicker : MonoBehaviour
{
    private Button _button;
    private AudioSource _audioSource;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _audioSource = GetComponent<AudioSource>();
    }

    protected void OnEnable()
    {
        _button.onClick.AddListener(Click);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(Click);
    }

    private void Click()
    {
        _audioSource.Play();
    }    
}
