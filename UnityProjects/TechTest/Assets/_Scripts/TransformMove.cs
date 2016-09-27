using UnityEngine;
using System.Collections;

public class TransformMove : MonoBehaviour {
	
	public float x = 0.0f;
	public float y = 0.0f;
	public float z = 0.0f;

	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (x, y, z) * Time.deltaTime);
	}
}