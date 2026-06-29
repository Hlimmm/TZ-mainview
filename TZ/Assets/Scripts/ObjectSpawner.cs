using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject targetObject;

    //  нопка 1 вызывает этот метод
    public void ShowObject()
    {
        if (targetObject != null) targetObject.SetActive(true);
    }

    //  нопка 2 вызывает этот метод
    public void HideObject()
    {
        if (targetObject != null) targetObject.SetActive(false);
    }
}