using UnityEngine;

public class SetSoundButtonAtStart : MonoBehaviour
{
    [SerializeField] GameObject musicVolumeOn;
    [SerializeField] GameObject soundVolumeOn;
    [SerializeField] SetSoundAtStart setSoundAtStart;

    private void Start()
    {
        if(setSoundAtStart.musicLevel<0)
            musicVolumeOn.SetActive(false);
        if (setSoundAtStart.soundLevel < 0)
            soundVolumeOn.SetActive(false);
    }
}
