using TMPro;
using UnityEngine;

public class TextAnim : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] string[] replicas;
    [SerializeField] GameObject StartAnim;
    [SerializeField] GameObject NextChar;
    int i = 0;

    public  void Next()
    {
        i++;
        if(i<replicas.Length)
        text.text = replicas[i];
        else
        {
            if(NextChar!=null)
            NextChar.SetActive(true);
            StartAnim.SetActive(false);
        }
    }

    private void Start()
    {
        text.text = replicas[i];
    }
}
