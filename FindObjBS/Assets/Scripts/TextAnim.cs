using TMPro;
using UnityEngine;
using YG;

public class TextAnim : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] string[] replicas;
    [SerializeField] string[] EngReplicas;
    [SerializeField] GameObject StartAnim;
    [SerializeField] GameObject NextChar;
    int i = 0;

    public void Next()
    {
        i++;
        if (YandexGame.EnvironmentData.language == "ru")
        {
            if (i < replicas.Length)
                text.text = replicas[i];
            else
            {
                if (NextChar != null)
                    NextChar.SetActive(true);
                StartAnim.SetActive(false);
            }

        }
        else
        {
            if (i < EngReplicas.Length)
                text.text = EngReplicas[i];
            else
            {
                if (NextChar != null)
                    NextChar.SetActive(true);
                StartAnim.SetActive(false);
            }

        }
    }

    private void Start()
    {
        if (YandexGame.EnvironmentData.language == "ru")
            text.text = replicas[i];
        else
            text.text = EngReplicas[i];
    }
}
