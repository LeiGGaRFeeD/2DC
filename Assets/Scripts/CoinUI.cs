using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = PlayerPrefs.GetInt("Coins").ToString();

        if (Input.GetKeyDown(KeyCode.R)) //Когда нажата клавиша R
        {
            PlayerPrefs.SetInt("Coins", 0); //Обнуляем Coins
        }
    }
}
