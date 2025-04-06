using UnityEngine;

public class TextAnimator : MonoBehaviour
{
    public Text textField; // Поле для вывода текста
    public string fullText; // Полный текст, который нужно анимировать
    public float delayBetweenLetters = 0.1f; // Задержка между появлением букв
    private void Start()
    {
        textField.text = ""; // Очищаем текстовое поле в начале
        StartCoroutine(AnimateText());
    }
    private IEnumerator AnimateText()
    {
        foreach (char letter in fullText.ToCharArray())
        {
            textField.text += letter; // Добавляем одну букву
            yield return new WaitForSeconds(delayBetweenLetters); // Ждем перед добавлением следующей буквы
        }
    }
}
