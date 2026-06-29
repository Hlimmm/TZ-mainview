using UnityEngine;

public class ObjectHide : MonoBehaviour
{
    // Ссылка на ваш объект
    public GameObject targetObject;

    public void ToggleObject()
    {
        if (targetObject != null)
        {
            // Проверяем текущее состояние и меняем на противоположное
            bool isActive = targetObject.activeSelf;
            targetObject.SetActive(!isActive);
        }
    }
}