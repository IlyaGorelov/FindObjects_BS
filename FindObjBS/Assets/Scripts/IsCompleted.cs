using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class IsCompleted : MonoBehaviour
{
    [SerializeField] AllObjects allObjects;
    [SerializeField] GameObject WinUI;

    private void Update()
    {
        if (allObjects.objects.Count==0) {
            YandexGame.savesData.openedLevels[SceneManager.GetActiveScene().buildIndex + 1] = true;
            YandexGame.SaveProgress();
            WinUI.SetActive(true);
        }
    }
}
