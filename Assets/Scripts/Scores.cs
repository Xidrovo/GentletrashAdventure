using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour {
    public Text gentleScore;
    public Text kiddieScore;
	// Use this for initialization
	void Start () {
        Debug.Log(GlobalRules.KiddieScore.ToString());
        gentleScore.text = GlobalRules.GentleScore.ToString();
        kiddieScore.text = GlobalRules.KiddieScore.ToString();
	}
}
