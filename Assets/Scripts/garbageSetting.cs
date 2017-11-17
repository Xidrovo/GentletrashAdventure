using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbageSetting : MonoBehaviour {

    private bool onGround = false;
	void Start () {
        //Ignores Default and Wall Layer collision. Also ignores default to default collisions
        Physics2D.IgnoreLayerCollision(10, 10);
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "gnd" && !onGround) { GlobalRules.health -= 5; onGround = true; }
    }
}
