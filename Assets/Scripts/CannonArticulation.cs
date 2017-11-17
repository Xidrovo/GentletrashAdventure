﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonArticulation : MonoBehaviour {

    public float rotationSpeed = 5f;
    public float maxAngle = 90f, minAngle = -90f;
    //Esto cambiará la dirección de la rotación dependiendo del ángulo máximo y mínimo que se quiera
    private int direction = 1;
    private bool goingUp = true;
	
    private void Update()
    {
        this.transform.Rotate(0,0, rotationSpeed*Time.deltaTime*direction , Space.World);

        if (this.transform.eulerAngles.z > maxAngle && goingUp) { direction = direction*-1; goingUp = false; }
        if ((this.transform.eulerAngles.z) -360 > minAngle && !goingUp) { direction = direction*-1; goingUp = true; Debug.Log("asdasd"); }
        Debug.Log(this.transform.eulerAngles.z);
        
    }
}
