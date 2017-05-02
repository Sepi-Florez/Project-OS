using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

    public static TouchManager thisManager;

    bool i = false;
    void Update() {
        if (Input.touches.Length > 0) {

            foreach (Touch touch in Input.touches) {
                switch (touch.fingerId) {
                    case 0:
                        if (!i) {
                            Aim(touch);
                        }
                        else {
                            Fire(touch);
                        }
                        break;
                    case 1:
                        if (i) {
                            Aim(touch);
                        }
                        else {
                            Fire(touch);
                        }
                        break;
                }
            }
        }
    }
    void Aim(Touch touch) {
        if (touch.phase == TouchPhase.Began) {
            OSDS.player.Move(transform.GetComponent<Camera>().ScreenToWorldPoint(touch.position));
        }
        if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) {
            OSDS.player.Move(transform.GetComponent<Camera>().ScreenToWorldPoint(touch.position));
        }
        if (touch.phase == TouchPhase.Ended) {
            OSDS.player.Shoot();
            if(Input.touches.Length == 2) {
                i = !i;
            }
            else if(touch.fingerId == 1) {
                i = !i;
            }
        }
    }
    void Fire(Touch touch) {
        if (touch.phase == TouchPhase.Ended) {
            OSDS.player.Shoot();
        }
    }
}

