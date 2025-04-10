using UnityEngine;
using UnityEngine.UI;

public class ToogleSwitcher : MonoBehaviour
{
    private Toggle _toggle;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
    }

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(Switch);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(Switch);
    }

    private void Switch(bool change)
    {
        AudioListener.pause = change;
    }
}
