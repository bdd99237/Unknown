﻿using UnityEngine;
using System.Collections;

public class ObjMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0.03f, 0);
	}
}
