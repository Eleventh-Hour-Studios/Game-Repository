using UnityEngine;
using System.Collections;

public class GetObjectName : MonoBehaviour {

	public string[] childName;
	private float childCNT;

	// Use this for initialization
	void Start () {
		childCNT = transform.childCount;
		Debug.Log (childCNT);
	}
}