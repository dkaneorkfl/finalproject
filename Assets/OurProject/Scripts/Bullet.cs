using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
string forTagNameCompare;
string[] ftnc;
void OnTriggerEnter(Collider other)
{
	forTagNameCompare = other.transform.tag;
	ftnc = new string[2];
	ftnc = forTagNameCompare.Split('.');
	if(ftnc.Length == 1)
	{
		if(ftnc[0] != transform.tag)
		{
			Debug.Log("Hit to Body!");
			Destroy(gameObject);
		}
		if(ftnc[0] == transform.tag+".Bullet")
		{
			Debug.Log("Absolve!");
			Destroy(gameObject);}
		}
		else
		{
			Debug.Log("Bullet Hit!");
		}
		Destroy(gameObject,3);
	}
}
