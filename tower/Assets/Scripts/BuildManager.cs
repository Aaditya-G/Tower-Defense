using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    void Awake () {
        if(instance != null) {
            // more than one BuildManager in scene
            return;
        }
        instance = this;
    }

    public GameObject standardTurrentPreFab; 

    void Start() {
        turretToBuild = standardTurrentPreFab;
    }

    private GameObject turretToBuild; 

    public GameObject GetTurretToBuild () {
        return turretToBuild;
    }
}
