using UnityEngine;
using System.Collections;

public class FishJump : MonoBehaviour {

	// Use this for initialization
	private Rigidbody rigidbody;
	 
	private int bodyInAirCount = 0;

	private int colliderCount = 0;

	private FishSwim fishSwim;

	void Start () {
	 
		rigidbody = GetComponent<Rigidbody> ();

		colliderCount = GetComponents<BoxCollider> ().Length + GetComponents<SphereCollider>().Length + GetComponents<CapsuleCollider>().Length;

		fishSwim = GetComponent<FishSwim> ();
	}
	
	void Jump(){
		
		if (colliderCount == 1) {
		
			if (bodyInAirCount == 0) {

				rigidbody.useGravity = false;

				rigidbody.drag = 4;

				fishSwim.SetForceEnable (true);

			} else {
				
				rigidbody.useGravity = true;

				rigidbody.drag = 0;

				fishSwim.SetForceEnable (false);
			}
		} else if (colliderCount == 2) {
			
			if (bodyInAirCount == 0) {

				rigidbody.useGravity = false;

				rigidbody.drag = 4;

				fishSwim.SetForceEnable (true);

			} else if (bodyInAirCount == 1) {

				rigidbody.useGravity = true;

				rigidbody.drag = 4;

				fishSwim.SetForceEnable (true);

			} else {
				
				rigidbody.useGravity = true;

				rigidbody.drag = 0;

				fishSwim.SetForceEnable (false);
			}
		} else {
			
			if (bodyInAirCount == 0) {

				rigidbody.useGravity = false;

				rigidbody.drag = 4;

				fishSwim.SetForceEnable (true);

			} else if (bodyInAirCount == 1) {

				rigidbody.useGravity = false;

				rigidbody.drag = 4;

				fishSwim.SetForceEnable (true);

			} else if (bodyInAirCount == 2) {

				rigidbody.useGravity = true;

				rigidbody.drag = 4;

				fishSwim.SetForceEnable (false);

			} else {

				rigidbody.useGravity = true;

				rigidbody.drag = 0;

				fishSwim.SetForceEnable (false);
			}
		}
	}

	void OnTriggerEnter(Collider other) {

		//判断是否为水面
		if (other.gameObject.layer == 8) {

			bodyInAirCount++;

			Jump ();
		}

	}
	void OnTriggerExit(Collider other) {

		//判断是否为水面
		if (other.gameObject.layer == 8) {

			bodyInAirCount--;

			Jump ();
		}
	}
}
