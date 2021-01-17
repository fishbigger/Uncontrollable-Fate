using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI textBox;

    public string Text;

    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        coroutine = WriteText(Text, textBox);
        StartCoroutine(coroutine);
    }

    private IEnumerator WriteText(string text, TextMeshProUGUI textBox)
    {
        string writtenText = "";
        foreach (char c in text) {
            yield return new WaitForSeconds(0.01f);

            writtenText = writtenText + c;

            textBox.text = writtenText;
        }
    }
}
