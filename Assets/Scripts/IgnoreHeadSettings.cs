using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IgnoreHeadSettings : MonoBehaviour {

    // Use this for initialization
    public Text Score;
	private void Awake () {
        Physics2D.IgnoreLayerCollision(0, 9);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10) {
            Score.text = int.Parse(Score.text) + 1 + "";
            if (this.gameObject.tag == "Kiddiecan")
                GlobalRules.KiddieScore += 1;
            else
                GlobalRules.GentleScore += 1;

            GlobalRules.health += 2 / GlobalRules.PLAYERS;
            Destroy(collision.gameObject);
        }
    }
}
