using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public static float wordSpeed = 1.0f;
    public static int Currentscore = 0;
    public static int HighScore = 0;
    public Text text;
    public Slider WordSpeed;

    public void SetWord(string word)
    {
        text.text = word;
        text.color = KeepData.ColorOption;
    }


    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }
    
    /*
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "word")       // If the object that was entered has the tag "Pickup"
        {

            other.gameObject.SetActive(false);      // Then set that object to be inactive (hide it)
            KeepData.Missed += 1;
            KeepData.Missed = "Score: " + KeepData.Missed;     // Updates the text property of scoreText
           
        }
    }/*/

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
