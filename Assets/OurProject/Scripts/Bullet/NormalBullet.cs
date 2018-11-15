using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet {

	// Use this for initialization
	protected override void Start () 
	{
		Destroy(gameObject,3);
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*100);
	}
}
