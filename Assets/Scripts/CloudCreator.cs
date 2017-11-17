using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCreator : MonoBehaviour {

    public GameObject cloudPrefab;
    private GameObject cloud;
    private float cloudScale;
	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateCloud", 0, 10f);
	}


    void GenerateCloud()
    {
        cloud = (GameObject)Instantiate(cloudPrefab, transform.position + new Vector3(0,Random.Range(-2,8)), transform.rotation);
        
        cloudScale = Random.Range(1, 3);
        cloud.GetComponent<Rigidbody2D>().mass = cloudScale + 0.5f;
        cloud.GetComponent<Transform>().transform.localScale = new Vector3(cloudScale, cloudScale, 0);
    }
}
