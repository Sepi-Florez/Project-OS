using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {
    public static Planet planet;

    public int health = 100;

    void Awake() {
        planet = this;
    }

    void OnTriggerEnter2D(Collider2D intruder) {
        if(intruder.transform.tag == "Enemy") {
            Enemy enemy = intruder.GetComponent<Enemy>();
            health -= enemy.damage;
            enemy.Destroyed();
  

            if(health <= 0) {
                GameManager.thisManager.GameOver();
            }
        }
    }
}
