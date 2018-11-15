using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveBullet : Bullet {
	float notGuideTime;
	public float curveRate;
	protected override void Start()
	{
		
		Destroy(gameObject,3);
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*100);
	}
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(Vector3.up*curveRate*Time.deltaTime);
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*100);
	}
}
