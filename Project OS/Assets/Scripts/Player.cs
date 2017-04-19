using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    bool gameOver = false;

    int health;
    public bool shield = true;
    float regenTime = 2f;

    Coroutine regen;
    void Update() {
        if (!gameOver) {
            Controls();
        }
    }
    void Controls() {
        if (Input.touches.Length > 0) {

            if (Input.touches[0].phase == TouchPhase.Ended) {
            }
        }
    }
    void Shoot(Vector3 dir) {
        GameObject projectile =(GameObject)Instantiate(ProjectileManager.thisManager.EquipedProjectile,transform.forward,Quaternion.identity);
    }
    private void OnTriggerEnter(Collider Intruder) {
        if(Intruder.transform.tag == "Enemy") {
            if (shield) {
                shield = false;
                regen = StartCoroutine(RegenerateShield());
                return;
            }
            health--;
            if(health == 0) {
                GameOver();
            }
        }
    }
    IEnumerator RegenerateShield() {
        yield return new WaitForSeconds(regenTime);
        shield = true;
    }
    void GameOver() {

    }
}
