﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour {

    public GameObject top;
    Vector3 aradakiMesafe;

	// Use this for initialization
	void Start () {

        aradakiMesafe = transform.position - top.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        
        transform.position = top.transform.position + aradakiMesafe;
		
	}
}
