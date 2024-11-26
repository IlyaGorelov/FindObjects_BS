using UnityEngine;
using YG;

public class GameStartStop : MonoBehaviour
{
    [SerializeField] GameObject[] Uis;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        YandexGame.GameplayStart();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;

        foreach (GameObject go in Uis)
        {
            if (go.activeSelf) i++;
        }

        if(i==0)
            YandexGame.GameplayStart();
        if (i > 0)
            YandexGame.GameplayStop();
    }
}
