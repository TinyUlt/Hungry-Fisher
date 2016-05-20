using UnityEngine;
using System.Collections;

public class FishThreatenOthers : MonoBehaviour {

	// Use this for initialization

	public float radius = 2.5F;

	void Start () {

		//
		GameObject threatenGameObject = new GameObject();

		threatenGameObject.name = "threatenGameObject";

		threatenGameObject.layer = 10;
	
		threatenGameObject.GetComponent<Transform> ().SetParent (transform, false);

		//
		SphereCollider sc = threatenGameObject.AddComponent<SphereCollider> ();

		sc.radius = radius;

		sc.center = Vector3.zero;

		sc.isTrigger = true;

		//
		threatenGameObject.AddComponent<FishThreatenOthersCollider> ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}

public class FishThreatenOthersCollider:MonoBehaviour{

	void OnTriggerEnter(Collider other) {

		//检测到为食物
		if (other.gameObject.layer == 11) {


		}

	}
	void OnTriggerExit(Collider other) {
		
		//检测到为食物
		if (other.gameObject.layer == 11) {


		}
	}
}
