using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName = "default name";
    public static int Currentscore = 0;
    public static int HighScore = 0;
    public static Color ColorOption = Color.white;
    public InputField playerName;
    public Dropdown ColorOfWord;
    public Text ShowName;
   
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()    //updates on input change for input field
    {
        ShowName.text = playerName.text;
    }
  
       
    public void setColorOfWord()
    {
        switch (ColorOfWord.value)
        {
            case 1:
                ColorOption = Color.white;
                break;
            case 2:
                ColorOption = Color.blue;
                break;
            case 3:
                ColorOption = Color.yellow;
                break;
            
            default:
                ColorOption = Color.green;
                break;
        }
    }
  


}