﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyShootBullet : MonoBehaviour {
public GameObject _bullet;
public GameObject firePosition;
private float _cooltime;
[SerializeField]private float _speed;
	// Use this for initialization
	void Start () {
		_cooltime = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {
		_cooltime -= Time.deltaTime;
		if(_cooltime<0)
		{
			_cooltime = 0.7f;
			Fire();
		}
	}

    private void Fire()
    {
        GameObject bullet 
			= Instantiate(
				_bullet,
				firePosition.transform.position,
				transform.rotation);
				bullet.transform.tag = $"{transform.tag}"+".Bullet";
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*_speed);
			bullet.GetComponent<Renderer>().material.color =
			GetComponent<Renderer>().material.color;
			Destroy(bullet,3);
    }
}
