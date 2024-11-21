using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNextLevel : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject LoadUI;
    public void Load()
    {
        LoadUI.SetActive(true);
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        while (async.isDone)
        {
            slider.value = async.progress;
            yield return null;
        }
    }
}
