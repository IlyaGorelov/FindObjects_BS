using System.Collections;
using TMPro;
using UnityEngine;

public class Hint : MonoBehaviour
{
    [SerializeField] AllObjects allObjects;
    [SerializeField] GameObject focus;
    [SerializeField] TextMeshProUGUI countText;
    [SerializeField] GameObject Close;
    public int useCount = 3;
    private bool canUseHint = true;
    [SerializeField] float speed = 1;
    private GameObject aim;

    private void Update()
    {
        if (useCount <= 0)
        {
            Close.SetActive(true);
        }
        else
        {
            Close.SetActive(false);
        }

        countText.text = useCount.ToString();

        if (!canUseHint)
        {
            focus.transform.position = Vector2.Lerp(focus.transform.position, aim.transform.position, Time.deltaTime * speed);
        }
        if (!allObjects.objects.Contains(aim))
        {
            focus.transform.position = transform.position;
            canUseHint = true;
            focus.SetActive(false);
            StopAllCoroutines();
        }

    }

    public void UseHint()
    {
        if (canUseHint)
        {
            useCount--;
            aim = allObjects.objects[0];
            canUseHint = false;
            focus.SetActive(true);
            StartCoroutine(GoBack());
        }
    }

    IEnumerator GoBack()
    {
        yield return new WaitForSeconds(5f);
        focus.transform.position = transform.position;
        canUseHint = true;
        focus.SetActive(false);
    }
}
