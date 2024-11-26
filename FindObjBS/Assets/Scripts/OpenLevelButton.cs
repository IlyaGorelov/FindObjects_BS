using UnityEngine;
using UnityEngine.Audio;
using YG;

public class OpenLevelButton : MonoBehaviour
{
    [SerializeField] int levelId;
    [SerializeField] GameObject closeObject;
    public bool i;

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
        i = YandexGame.savesData.openedLevels[levelId];
        if (YandexGame.savesData.openedLevels[levelId])
            closeObject.SetActive(false);
    }


}
