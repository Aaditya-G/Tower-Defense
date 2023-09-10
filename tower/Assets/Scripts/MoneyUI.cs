using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    PlayerStats playerStats = PlayerStats.instance;

//     void Start () {
//     playerStats =  PlayerStats.instance;
//    }



    // Update is called once per frame
    void Update()
    {
        //int money = playerStats.GetMoney();
        //moneyText.text = "$" +  money.ToString();
        moneyText.text = "$" +  PlayerStats.Money.ToString();
    }
}
