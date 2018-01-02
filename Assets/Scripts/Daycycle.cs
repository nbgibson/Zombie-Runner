﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour {

    [Tooltip ("Number of minutes per second that pass")]
    public float minutesPerSecond;

    	
	// Update is called once per frame
	void Update () {
        float angleThisFrame = Time.deltaTime / 360;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
