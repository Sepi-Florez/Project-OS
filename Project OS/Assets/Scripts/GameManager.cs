using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager thisManager;

    public bool gameOver;
	// Use this for initialization
	void Awake () {
        thisManager = this;
	}
    public void GameOver() {

    }
}
