using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundChange : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;

    public void Change()
    {
        float dbValue;
        if (slider.value > 0)
        {
            dbValue = Mathf.Log10(slider.value) * 20;
        }
        else
        {
            dbValue = -80;
        }
        audioMixer.SetFloat("Volume", dbValue);
        PlayerPrefs.SetFloat("Volume", slider.value);
    }
}
