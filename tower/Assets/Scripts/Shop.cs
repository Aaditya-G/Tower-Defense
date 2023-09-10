using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
    public TurretBlueprint missileTurret;
	
	BuildManager buildManager;

	void Start ()
	{
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret ()
	{
		Debug.Log("Standard Turret Selected");
		buildManager.SelectTurretToBuild(standardTurret);
		//code to check if player has enough money then increase standard turret count
	}

	public void SelectMissileTurret()
	{
		Debug.Log("Another Turret Selected");
		buildManager.SelectTurretToBuild(missileTurret);
	}

}