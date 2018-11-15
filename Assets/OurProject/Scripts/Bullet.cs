using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
GameObject player;
string forTagNameCompare;
string[] ftnc;

void Start()
{
	player = GameObject.Find("Capsule")	;
}

void OnTriggerEnter(Collider other)
{
	forTagNameCompare = other.transform.tag;
	ftnc = new string[2];
	ftnc = forTagNameCompare.Split('.');
	if(ftnc.Length == 1)
	{
		ftnc[0] = $"{ftnc[0]}"+".Bullet";
		if(ftnc[0] != transform.tag)
		{
			Debug.Log("Hit to Body!");
			if(other.GetComponent<PlayerDirector>())
			other.GetComponent<PlayerDirector>().HP--;
			else if(other.GetComponent<EnermyShootBullet>())
			other.GetComponent<EnermyShootBullet>().HP--;
			else
			return;
			Destroy(gameObject);
		}
		if(ftnc[0] == transform.tag)
		{
			Debug.Log("Absolve!");
			if(other.GetComponent<PlayerDirector>())
			other.GetComponent<PlayerDirector>().Score+=100;
			else
			return;
			Destroy(gameObject);}
		}
		else
		{
			Debug.Log("Bullet Hit!");
		}
	}
}
