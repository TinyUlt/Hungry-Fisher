using UnityEngine;
using System.Collections;

public class FishBeingThreaten : MonoBehaviour {

	private Rigidbody rigidbody;


	void Start(){

		rigidbody = GetComponent<Rigidbody> ();
	}


	void OnTriggerEnter(Collider other) {

		//检测到为危险
		if (other.gameObject.layer == 10) {
			
		}

	}

	void OnTriggerStay(Collider other) {

		//检测到为危险
		if (other.gameObject.layer == 10) {

		}

	}

	void OnTriggerExit(Collider other) {

		//检测到为危险
		if (other.gameObject.layer == 10) {

		}

	}
}
