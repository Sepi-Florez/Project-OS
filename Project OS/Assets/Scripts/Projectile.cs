using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed;
    public int damage;

    Vector3 dir;
    private void Awake() {
        dir = -OSDS.player.transform.up;
    }

    void Update() {
        Movement();
    }
    void Movement() {
        transform.Translate(dir * speed);
    }
}
