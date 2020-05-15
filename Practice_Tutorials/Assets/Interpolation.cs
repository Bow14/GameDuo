using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolation : MonoBehaviour
{
	private float result = Mathf.Lerp(3f, 5f, 0.5f);
	static Vector3 from = new Vector3(1f, 2f, 3f);
	static Vector3 to = new Vector3(5f, 6f, 7f);

	Vector3 _result = Vector3.Lerp(from, to, 0.75f);

	private float duration = 1.0f;
	Color color2 = Color.red;
	Color color3 = Color.blue;

	private Light it;
	// Use this for initialization
	void Start ()
	{
		it = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float t = Mathf.PingPong(Time.time, duration) / duration;
		it.color = Color.Lerp(color2, color3, t);
		
	}
}
