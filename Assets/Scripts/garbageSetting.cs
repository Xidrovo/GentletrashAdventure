using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbageSetting : MonoBehaviour {

	void Start () {
        //Ignores Default and Wall Layer collision. Also ignores default to default collisions
        Physics2D.IgnoreLayerCollision(10, 10);
	}
}
