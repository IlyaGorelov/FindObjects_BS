using UnityEngine;

public class ChangeObjectsActive : MonoBehaviour
{
    [SerializeField] GameObject go;

    public void Change()
    {
        go.SetActive(!go.activeSelf);
    }
}
