using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
    public Slider slider;
    public AudioMixer audioMixer;

    private float valueSlide;
    private void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            valueSlide = PlayerPrefs.GetFloat("Volume");
            slider.value = valueSlide;

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
        }
    }

}
