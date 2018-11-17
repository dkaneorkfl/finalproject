using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidedBullet : Bullet {
	
	float notGuideTime = 1;
	// Update is called once per frame
	void Update () 
	{
		notGuideTime -= Time.deltaTime;
		Debug.Log(notGuideTime);
		if(notGuideTime < 0)
		{
		transform.LookAt(player.transform);
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*bulletSpeed);
		}
	}
}
