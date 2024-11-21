using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class SkipLevel : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject LoadUI;

    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Rewarded;
    }

    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Rewarded;
    }

    private void Rewarded(int i)
    {
        if (i == 1)
        {
            Load();
        }
    }

    public void Skip()
    {
        YandexGame.RewVideoShow(1); 
    }

    private void Load()
    {
        YandexGame.savesData.openedLevels[SceneManager.GetActiveScene().buildIndex + 1] = true;
        YandexGame.SaveProgress();
        LoadUI.SetActive(true);
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);

        while (async.isDone)
        {
            slider.value = async.progress;
            yield return null;
        }
    }
}
