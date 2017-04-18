using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed;
    public int damage;
    void Update() {
        Movement();
    }
    void Movement() {
        transform.Translate(-transform.up * speed);
    }
}
