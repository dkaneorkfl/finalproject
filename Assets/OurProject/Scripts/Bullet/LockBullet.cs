using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBullet : Bullet {

	GameObject target;
	// Use this for initialization
	protected override void Start()
	{
		target = GameObject.Find("Capsule");
		transform.LookAt(target.transform);
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*bulletSpeed);
	}
}
