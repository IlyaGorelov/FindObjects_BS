using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLeevel : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject LoadUI;

    public void Load(int level)
    {
        LoadUI.SetActive(true);
        StartCoroutine(LoadAsync(level));
    }

    IEnumerator LoadAsync(int i)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(i);

        while (async.isDone)
        {
            slider.value = async.progress;
            yield return null;
        }
    }
}
