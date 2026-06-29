using UnityEngine;
using UnityEngine.UI; // или TMPro, если используете его

public class ClearInputField : MonoBehaviour
{
    // Переменная вашего инпута теперь внутри этого класса
    public InputField inputfield1;

    // Ваш основной код (например, вывод в консоль)
    // ...

    // Метод очистки тоже внутри этого класса
    public void ClearInput()
    {
        inputfield1.text = "";
    }
}
