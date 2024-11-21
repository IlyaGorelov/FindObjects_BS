using UnityEngine;
using UnityEngine.Audio;
using YG;

public class SetSoundAtStart : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    public float musicLevel;
    public float soundLevel;

    private void OnEnable()
    {
        YandexGame.GetDataEvent += Load;
    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= Load;
    }

    private void Start()
    {
        if (YandexGame.SDKEnabled)
            Load();
    }

    private void Load()
    {
        musicLevel = YandexGame.savesData.musicVolume;
        audioMixer.SetFloat("Music", musicLevel);
        soundLevel = YandexGame.savesData.soundVolume;
        audioMixer.SetFloat("Sound", soundLevel);
    }
}
