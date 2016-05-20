using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerControl : MonoBehaviour {

	public float m_Speed = 50.0F;

	private FishSwim fishSwim; 
	// Use this for initialization
	void Start () {
		fishSwim = GetComponent<FishSwim> ();
	}

	// Update is called once per frame
	void Update(){

		Vector3 movement;

		bool jbd = CrossPlatformInputManager.GetButtonDown("Jump");

		bool jbu = CrossPlatformInputManager.GetButtonUp("Jump");


		if (jbd) {
			print ("jbd");
			m_Speed *= 2;
		}
		if (jbu) {
			print ("jbu");

			m_Speed /= 2;
		}
		float speed = m_Speed;
		if (!(jbd || jbu)) {
			if (Input.GetAxis ("Jump") > 0) {
				speed = m_Speed * 2;
			}
		}

		//		float h = Input.GetAxis ("Horizontal");

		float h = CrossPlatformInputManager.GetAxis ("Horizontal");

		float v = CrossPlatformInputManager.GetAxis ("Vertical");

		if (h  == 0) {

			h = Input.GetAxis ("Horizontal");
		}
		if (v ==0) {

			v = Input.GetAxis ("Vertical");
		}
		movement = new Vector3 (h, v, 0.0F);

		movement = Vector3.ClampMagnitude (movement, 1);


		//		FP.setMovement (movement);
		movement *= speed;

		fishSwim.setDrivingForce (movement);
	}
}
