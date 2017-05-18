using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [SerializeField]
    int health;
    public int damage;
    public float speed;
    int score;
 

    void OnTriggerEnter2D(Collider2D intruder) {
        if(intruder.transform.tag == "Projectile") {
            Projectile proj = intruder.GetComponent<Projectile>();
            health -= proj.damage;
            if(health <= 0) {
                Destroyed();
            }
            proj.Destroyed();
        }
    }
    public void Destroyed() {
        Destroy(gameObject);
    }
}
