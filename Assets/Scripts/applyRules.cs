using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class applyRules : MonoBehaviour {

    public GameObject kiddieCan;
    public Text Name, Score;

	// Use this for initialization
	void Start () {
        if (GlobalRules.PLAYERS == 1) { 
            Destroy(kiddieCan);
            Destroy(Name);
            Destroy(Score);

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
