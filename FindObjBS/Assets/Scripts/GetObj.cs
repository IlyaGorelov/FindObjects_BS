using UnityEngine;

public class GetObj : MonoBehaviour
{
    [SerializeField] Transform goTo;
    [SerializeField] float speed = 1;
    [SerializeField] IsCompleted isCompleted;
    [SerializeField] GameObject audioObj;
    [SerializeField] AllObjects allObjects;
    private bool canDo;

    public void ChangePos()
    {
        if (goTo.gameObject.activeSelf)
        {
            audioObj.SetActive(true);
            OpenNewObj.canOpenNew = true;
            canDo = true;
            allObjects.objects.Remove(gameObject);
        }
    }

    void Update()
    {
        if (canDo)
        {
            transform.position = Vector2.Lerp(transform.position, goTo.position, speed * Time.deltaTime);
            transform.localScale = goTo.localScale;
        }
    }
}
