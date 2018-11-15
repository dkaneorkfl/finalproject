using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidedBullet : Bullet {
	GameObject target;
	// Use this for initialization
	protected override void Start()
	{
		target = GameObject.Find("Capsule");
		Destroy(gameObject,3);
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt(target.transform);
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*100);
	}
}
