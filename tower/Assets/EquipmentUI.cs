using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EquipmentUI : MonoBehaviour
{
    public TextMeshProUGUI equipmentText;
    public GameObject equipment;

    // Update is called once per frame
    void Update()
    {
        // Assuming "equipment" is the GameObject you want to check
        switch (equipment.name)
        {
            case "StandardTurret":
                equipmentText.text = PlayerStats.StandardTurretCount.ToString();
                break;
            case "MissileTurret":
                equipmentText.text = PlayerStats.MissileTurretCount.ToString();
                break;
            case "StandardFarm":
                equipmentText.text = PlayerStats.FarmCount.ToString();                
                break;
            default:
                Debug.Log("lmao");
                break;
        }

        
    }
}
