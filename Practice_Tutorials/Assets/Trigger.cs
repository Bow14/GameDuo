using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
	public UnityEvent test;
	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		test.Invoke();
	}

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
