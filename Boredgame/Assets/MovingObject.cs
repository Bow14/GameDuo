using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

	public Vector3 location;

	void Update () 
	{
		transform.Translate(location);
	}
}
