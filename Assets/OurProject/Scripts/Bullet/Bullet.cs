using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

public GameObject player;
string forTagNameCompare;
string[] ftnc;

protected virtual void Start()
{
	player = GameObject.Find("Capsule")	;
	Destroy(gameObject,3);
}

protected virtual void OnTriggerEnter(Collider other)
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
			else if(other.GetComponent<EnermyDirector>())
			other.GetComponent<EnermyDirector>().HP--;
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
