using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSDS : MonoBehaviour {

    public static OSDS player;

    public int health;
    public bool shield = true;
    public float regenTime = 2f;

    public Transform planet;

    Coroutine regen;
    void Awake() {
        player = this;
    }
    //Ask Alex how this works
    public void Move(Vector2 pos) {
        Vector3 dir = new Vector3(pos.x,pos.y,0) - planet.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        planet.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
    }
    public void Shoot() {
        GameObject projectile =(GameObject)Instantiate(ProjectileManager.thisManager.EquipedProjectile,transform.position,Quaternion.identity);
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
                GameManager.thisManager.GameOver();
            }
        }
    }
    IEnumerator RegenerateShield() {
        yield return new WaitForSeconds(regenTime);
        shield = true;
    }
}
