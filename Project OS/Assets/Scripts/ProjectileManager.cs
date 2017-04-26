using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour {
    public static ProjectileManager thisManager;
    public GameObject[] projectiles;
    public GameObject EquipedProjectile;


    void Awake () {
        thisManager = this;
	}
	void Update () {
		
	}
}
