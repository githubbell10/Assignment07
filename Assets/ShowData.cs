using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PlayerNameText;
    public Text wordSpeedText;
    

    private void Update()
    {
        {
           PlayerNameText.text = "Name: " +  KeepData.PlayerName;
           wordSpeedText.text = "Speed " + KeepData.WordSpeedMultiplier.ToString();

        }
    }

}
