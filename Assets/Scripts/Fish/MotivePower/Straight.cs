using UnityEngine;
using System.Collections;

public class Straight : MonoBehaviour {

	// Use this for initialization

	public float speed = 30;
	public float angle = 90;

	private FishSwim fishSwim; 
	void Start () {
	
	
		fishSwim = GetComponent<FishSwim> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		float x = Mathf.Sin (angle * Mathf.Deg2Rad);

		float y = Mathf.Cos (angle * Mathf.Deg2Rad);

		Vector3 movement = new Vector3 (x, y, 0.0F);



		movement *= speed;


		fishSwim.setDrivingForce (movement);
	}
}
