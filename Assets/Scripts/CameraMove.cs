﻿using UnityEngine;
using System.Collections;
//test
public class CameraMove : MonoBehaviour {

	public GameObject followObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3 (followObj.transform.position.x, followObj.transform.position.y, transform.position.z);//.x = followObj.transform.position.x;
	}
}
