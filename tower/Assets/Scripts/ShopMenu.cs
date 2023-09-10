using UnityEngine.SceneManagement;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    PlayerStats playerStats;

    void Start  () {
        playerStats = PlayerStats.instance;
    }


    public string sceneToLoad = "MainMenu";

    public void PurchaseStandardTurret () {

        if(PlayerStats.Money < 100 /*turretToBuild.cost*/) {
			//code 
			return;
		}

        PlayerStats.Money -= 100/*turretToBuild.cost*/;
        PlayerStats.StandardTurretCount ++;
        playerStats.SaveSTC();

    }

    public void PurchaseMissileTurret () {

        if(PlayerStats.Money < 800 /*turretToBuild.cost*/) {
			//code 
			return;
		}

        PlayerStats.Money -= 800/*turretToBuild.cost*/;
        PlayerStats.MissileTurretCount ++;
        playerStats.SaveMTC();
        
    }

    public void PurchaseFarm () {

        if(PlayerStats.Money < 300 /*turretToBuild.cost*/) {
			//code 
			return;
		}

        PlayerStats.Money -= 300/*turretToBuild.cost*/;
        PlayerStats.FarmCount++;
        playerStats.SaveFC();
        
    }


    public void SwitchScene() {
         SceneManager.LoadScene(sceneToLoad);
    }

}
