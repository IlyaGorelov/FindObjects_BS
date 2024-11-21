using UnityEngine;
using UnityEngine.Audio;
using YG;

public class ChangeSound : MonoBehaviour
{
    [SerializeField] SoundType soundType;
    [SerializeField] AudioMixer audioMixer;

   enum SoundType
    {
        Music, Sound
    }

    public void SoundButton(float i)
    {
        switch (soundType)
        {
            case SoundType.Music:
                audioMixer.SetFloat("Music", i);
                YandexGame.savesData.musicVolume = i;
                break;
            case SoundType.Sound:
                audioMixer.SetFloat("Sound", i);
                YandexGame.savesData.soundVolume = i;
                break;
        }
        YandexGame.SaveProgress();
    }
}
