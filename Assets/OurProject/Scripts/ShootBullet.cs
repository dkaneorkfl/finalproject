using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour {

GameObject firePosition;
Camera cam;
[SerializeField]private float _speed;
[SerializeField]private GameObject _bullet;
internal bool _changeColor;
	// Use this for initialization
	void Start () {
		cam = Camera.main;
		firePosition = GameObject.Find("Sphere");
	}
	
	// Update is called once per frame
	void Update () {
		Shoot();
	}

    private void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
		{
			GameObject bullet 
			= Instantiate(
				_bullet,
				firePosition.transform.position,
				transform.rotation);
				bullet.transform.tag = $"{transform.tag}"+".Bullet";
				Debug.Log(bullet.transform.tag);
				bullet.transform.name = transform.name;
			bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up*_speed);
			bullet.GetComponent<Renderer>().material.color =
			GetComponent<Renderer>().material.color;
			Destroy(bullet,3);
		}
    }
}
