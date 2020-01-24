using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
public class ZoomIn : MonoBehaviour {

	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public UnityEvent triggerEnterEvent, triggerExitEvent;
	public UnityEvent triggerEvent;
	private void OnTriggerEnter(Collider other)
	{
		triggerEvent.Invoke();
		triggerEnterEvent.Invoke();
	}
	private void OnTriggerExit(Collider other)
	{
		triggerExitEvent.Invoke();
	}
}
