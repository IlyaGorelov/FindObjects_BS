using UnityEngine;

public class OpenNewObj : MonoBehaviour
{
    private Transform[] objects;
    public static bool canOpenNew;

    private void Start()
    {
        objects = GetComponentsInChildren<Transform>();
        for (int i = 0; i < objects.Length; i++)
        {
            if (i >= 4)
            {
                objects[i].gameObject.SetActive(false);
            }
        }
    }

    private void Update()
    {
        if (canOpenNew)
        {
            canOpenNew = false;
            foreach (var obj in objects)
            {
                if(!obj.gameObject.activeSelf)
                {
                    obj.gameObject.SetActive(true);
                    break;
                }
            }
        }
    }
}
