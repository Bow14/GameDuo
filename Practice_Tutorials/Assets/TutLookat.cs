using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutLookat : MonoBehaviour {

	// this a unity tutorial 
	public Transform target;
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(transform);
	}
}
