using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPIndicator : MonoBehaviour {

float MaxHP;
float HP;
GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Capsule");
		MaxHP = player.GetComponent<PlayerDirector>().MaxHP;
	}
	
	// Update is called once per frame
	void Update () 
	{
		HP = player.GetComponent<PlayerDirector>().HP;
		transform.localScale = new Vector3(HP/MaxHP,1,1);
	}
}
