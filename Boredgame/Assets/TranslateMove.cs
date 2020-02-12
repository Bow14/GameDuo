using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMove : MonoBehaviour
{
	public float moveSpeed = 20f;

	public float rotationSpeed;
	// Update is called once per frame
	void Update () 
	{	
		//Moving the viewpoint
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left*moveSpeed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right*moveSpeed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.up*moveSpeed*Time.deltaTime);
		}	
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.down*moveSpeed*Time.deltaTime);
		}
		
	}
}
