using UnityEngine;
using System.Collections;

public class ParentOnCollision : MonoBehaviour {

	void OnCollisionEnter (Collision col) {
		transform.parent = col.transform;
	}
}