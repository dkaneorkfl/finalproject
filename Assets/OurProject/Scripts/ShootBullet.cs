using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour {
private Ray _ray;
private RaycastHit _ratHit;
[SerializeField]private GameObject _bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Aiming();
		Shoot();
	}

    private void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
		{

		}
    }

    private void Aiming()
    {
        throw new NotImplementedException();
    }
}
