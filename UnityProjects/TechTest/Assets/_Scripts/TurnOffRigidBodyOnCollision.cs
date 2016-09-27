using UnityEngine;
using System.Collections;

public class TurnOffRigidBodyOnCollision : MonoBehaviour {
	
	void OnCollisionEnter (Collision col) {
		Rigidbody test = gameObject.GetComponent<Rigidbody>() as Rigidbody;
		Destroy (test);
	}
}