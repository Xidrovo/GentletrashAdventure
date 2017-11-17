using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannon : MonoBehaviour
{

    public GameObject myPrefab;
    public float shootForce;
    private GameObject go;
    private Rigidbody2D rb_go;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("shoot", 0.5f, 0.8f);
    }

    private void shoot()
    {
        if(Random.Range(0f, 100f) > 45) { 
            //Creamos la munición.
            go = (GameObject)Instantiate(myPrefab, transform.position,transform.rotation);
            //Todo lo relacionado al disparo aquí abajo.
            rb_go = go.GetComponent<Rigidbody2D>();
            rb_go.AddRelativeForce(new Vector2(shootForce, 0f),ForceMode2D.Impulse);
        }
    }
}
