using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager thisManager;
	// Use this for initialization
	void Awake () {
        thisManager = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
