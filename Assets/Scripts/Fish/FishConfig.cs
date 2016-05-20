using UnityEngine;
using System.Collections;

public class FishConfig : MonoBehaviour {


	private Animator aim;

	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		
		aim = GetComponent<Animator> ();

		aim.speed = 0.4F;

		rigidbody = GetComponent<Rigidbody> ();

	}

	void setAnimatorSpeed(float speed){
		
		aim.speed = speed;
	}
	
	// Update is called once per frame

}
