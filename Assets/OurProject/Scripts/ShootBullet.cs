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
			//1.탄이 만들어진다
			//2.탄이 힘을 준다. 그 결과 탄이 날아간다.
			
			GameObject bullet = Instantiate(_bullet,transform.position,transform.rotation);
			bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward*100);
		}
    }

    private void Aiming()
    {
        
    }
}
