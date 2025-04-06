using UnityEngine;

public class TextAnimator : MonoBehaviour
{
    public Text textField; // ���� ��� ������ ������
    public string fullText; // ������ �����, ������� ����� �����������
    public float delayBetweenLetters = 0.1f; // �������� ����� ���������� ����
    private void Start()
    {
        textField.text = ""; // ������� ��������� ���� � ������
        StartCoroutine(AnimateText());
    }
    private IEnumerator AnimateText()
    {
        foreach (char letter in fullText.ToCharArray())
        {
            textField.text += letter; // ��������� ���� �����
            yield return new WaitForSeconds(delayBetweenLetters); // ���� ����� ����������� ��������� �����
        }
    }
}
