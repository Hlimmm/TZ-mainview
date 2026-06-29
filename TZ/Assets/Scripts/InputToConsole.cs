using UnityEngine;
using UnityEngine.UI; // Ёта строка ќЅя«ј“≈Ћ№Ќќ должна быть здесь

public class InputToConsole : MonoBehaviour
{
    public InputField InputField1;

    public void PrintInputToConsole()
    {
        if (InputField1 != null && !string.IsNullOrEmpty(InputField1.text))
        {
            Debug.Log("¬веденный текст: " + InputField1.text);
        }
        else
        {
            Debug.LogWarning("ѕоле ввода пусто!");
        }
    }
}