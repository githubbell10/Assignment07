using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName = "Default Name";
    public static float WordSpeedMultiplier = 1.0f;
    public static Color ColorOption = Color.white;
    public InputField playerName;
    public Dropdown ColorOfWord;
    public Slider WordSpeed;
    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()    //updates on input change for input field
    {
        PlayerName = playerName.text;
    }

    public void SetWordSpeedMultiplier()
    {
        WordSpeedMultiplier = WordSpeed.value;
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