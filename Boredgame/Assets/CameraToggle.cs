using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{


	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.C))
		{
			ToggleCamera();
		}
	}

	public void ToggleCamera()
	{
		Debug.Log("Camera");
	}
}
