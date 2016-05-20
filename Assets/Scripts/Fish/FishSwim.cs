using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
public class FishSwim : MonoBehaviour {

	public Transform HTransform;

	public Transform VTransform;

	public float radius = 5;

	private Rigidbody rigidbody;

	private Vector3 oldPosition;

	private Vector3 centerPt;

	private Vector3 hPosition;

	private Vector3 vPosition;

	private Vector3 drivingForce;

	private bool forceEnable =true;

	private Vector3 resetPosition = new Vector3(1, 1, 0);
	void Start () {

		rigidbody = gameObject.AddComponent<Rigidbody> ();

		rigidbody.angularDrag = 0.1F;

		rigidbody.useGravity = false;

		rigidbody.drag = 4;

		oldPosition = transform.position;

		hPosition = transform.position;

		vPosition = transform.position;
	}

	// Update is called once per frame
	void Update(){
		
		transform.position = Vector3.Scale(transform.position, resetPosition);

	}
	public void setDrivingForce(Vector3 force){

		drivingForce = force;
	}

	void FixedUpdate () {

		if (forceEnable) {
			
			rigidbody.AddForce (drivingForce);
		}

		Vector3 offset= transform.position - oldPosition;

		oldPosition = transform.position;

		HTurn (offset.x * 10, offset.y* 10);

		VTurn  (offset.x * 10, offset.y* 10);

	}

	public void SetForceEnable(bool enable){
		
		forceEnable = enable;
	}
	void HTurn(float x, float z){
		
		centerPt = transform.position;

		Vector3 movement = new Vector3(x, 0,  z);

		Vector3 newPos = hPosition + movement;

		Vector3 offset = newPos - centerPt;

		Vector3 p = centerPt + Vector3.ClampMagnitude (offset, radius);

		hPosition = p;

		p.z = -Mathf.Abs (p.z);

//		transform.position = p;

		if (HTransform) {
			
			HTransform.position = p;
		}



		transform.LookAt (p);
	}

	void VTurn(float x, float y){
		
		centerPt = transform.position;

		Vector3 movement = new Vector3(x,   y, 0);

		Vector3 newPos = vPosition + movement;

		Vector3 offset = newPos - centerPt;

		vPosition = centerPt + Vector3.ClampMagnitude(offset, radius);

		if (VTransform) {
			
			VTransform.position = vPosition;
		}


		float height = vPosition.y - transform.position.y;

		float angle = - height / radius * 90;

		transform.eulerAngles = new Vector3 (angle, transform.eulerAngles.y, transform.eulerAngles.z);
	}
//	void OnTriggerEnter(Collider other) {
//		bodyInAirCount++;
//	}
//	void OnTriggerExit(Collider other) {
//		bodyInAirCount--;
//	}
}
