using UnityEngine;
using YG;

public class GetHintsForAd : MonoBehaviour
{
    [SerializeField] Hint hint;

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
        if (i == 0)
        {
            hint.useCount += 1;
        }
    }

    public void GetHint()
    {
        YandexGame.RewVideoShow(0);
    }
}
