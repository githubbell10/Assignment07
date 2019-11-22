using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public static float wordSpeed = 1.0f;
    public Text text;
    //public float fallSpeed = 1.0f;

    public Slider WordSpeed;

    public void SetWord (string word)
    {
        text.text = word;
        text.color = KeepData.ColorOption;
    }


    public void RemoveLetter()
    {
        text.text = text.text.Remove(0,1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -wordSpeed * Time.deltaTime, 0f);
    }
    public void SetWordSpeed()
    {
        wordSpeed = WordSpeed.value;    // value of the slider
    }
}
