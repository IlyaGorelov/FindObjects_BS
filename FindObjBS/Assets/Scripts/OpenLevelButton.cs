using UnityEngine;
using UnityEngine.Audio;
using YG;

public class OpenLevelButton : MonoBehaviour
{
    [SerializeField] int levelId;
    [SerializeField] GameObject closeObject;

    private void OnEnable()
    {
        YandexGame.GetDataEvent += Load;
        if (YandexGame.SDKEnabled)
            Load();
    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= Load;
    }

    private void Load()
    {
        if (YandexGame.savesData.openedLevels[levelId])
            closeObject.SetActive(false);
    }


}
