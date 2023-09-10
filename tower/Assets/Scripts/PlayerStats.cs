using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public static PlayerStats instance;


    public static int Money;
    public int startMoney = 300;
    private string moneyKey = "PlayerMoney"; 
    
    public static int Xp;
    public int startXp = 0;
    private string XpKey = "PlayerXp"; 

    public static int XpLevel;
    public int startXpLevel = 1;
    private string XpLevelKey = "PlayerXpLevel"; 


    public static int StandardTurretCount;
    public int startStandardTurretCount = 1;
    private string STCkey = "PlayerStandardTurretCount"; 

    public static int MissileTurretCount;
    public int startMissileTurretCount = 0;
    private string MTCkey = "PlayerMissileTurretCount"; 

    public static int FarmCount;
    public int startFarmTurretCount = 0;
    private string FCkey = "PlayerFarmCount"; 




    void Start()
    {

        if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;

        Money = PlayerPrefs.GetInt(moneyKey, startMoney);
        //Money = startMoney;
        Xp = PlayerPrefs.GetInt(XpKey, startXp);
        XpLevel = PlayerPrefs.GetInt(XpLevelKey , startXpLevel);
        StandardTurretCount = PlayerPrefs.GetInt(STCkey , startStandardTurretCount );
        MissileTurretCount = PlayerPrefs.GetInt(MTCkey , startMissileTurretCount);

    }


    public void SaveMoney()
    {
        PlayerPrefs.SetInt(moneyKey, Money);
        PlayerPrefs.Save();
    }

    public void SaveXp()
    {
        PlayerPrefs.SetInt(XpKey, Xp);
        PlayerPrefs.Save();

        //code to check Xp  and update the xp level
    }

    public void SaveSTC() {
        PlayerPrefs.SetInt(STCkey , StandardTurretCount);
        PlayerPrefs.Save();
    }

    public void SaveMTC() {
        PlayerPrefs.SetInt(MTCkey , StandardTurretCount);
        PlayerPrefs.Save();
    }

      public void SaveFC() {
        PlayerPrefs.SetInt(FCkey , FarmCount);
        PlayerPrefs.Save();
    }


    public void ResetMoney()
    {
        Money = startMoney;
        SaveMoney();
    }
}
