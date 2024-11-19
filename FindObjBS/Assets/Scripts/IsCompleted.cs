using UnityEngine;

public class IsCompleted : MonoBehaviour
{
    [SerializeField] AllObjects allObjects;
    [SerializeField] GameObject WinUI;

    private void Update()
    {
        if (allObjects.objects.Count==0) {
            WinUI.SetActive(true);
        }
    }
}
