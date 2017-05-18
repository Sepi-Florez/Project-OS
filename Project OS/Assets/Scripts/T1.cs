using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1 : Enemy {
    void Start() {
        Vector3 dir = new Vector3(0, 0, 0) - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
    }
    void Update() {
        Movement();
    }
    void Movement() {
        transform.Translate(new Vector3(0,-1,0) * speed);
    }
}
