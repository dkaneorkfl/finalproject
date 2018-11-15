using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBullet : Bullet {

	GameObject target;
	RaycastHit hit;
	// Use this for initialization
	protected override void Start()
	{
		target = GameObject.Find("Capsule");
		Destroy(gameObject,3);
		transform.LookAt(target.transform);
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*100);
	}
}
