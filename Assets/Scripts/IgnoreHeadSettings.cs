using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreHeadSettings : MonoBehaviour {

	// Use this for initialization
	private void Awake () {
        Physics2D.IgnoreLayerCollision(0, 9);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10) {
            Debug.Log("Se destruye y ganas 1 punto");
            Destroy(collision.gameObject);
        }
    }
}
