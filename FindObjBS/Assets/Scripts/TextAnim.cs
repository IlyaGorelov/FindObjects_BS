using TMPro;
using UnityEngine;

public class TextAnim : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] string[] replicas;
    [SerializeField] GameObject StartAnim;
    int i = 0;

    public  void Next()
    {
        i++;
        if(i<replicas.Length)
        text.text = replicas[i];
        else  StartAnim.SetActive(false);
    }

    private void Start()
    {
        text.text = replicas[i];
    }
}
