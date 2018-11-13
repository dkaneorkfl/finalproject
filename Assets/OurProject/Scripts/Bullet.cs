using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

void OnCollisionEnter(Collision other)
{
	if(other.transform.tag != transform.tag)
	Debug.Log("Hit!");

	if(other.transform.tag == transform.tag)
	Debug.Log("Absolve!");

	Destroy(gameObject);
}
}
