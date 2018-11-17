using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootBullet : MonoBehaviour {

[SerializeField]private List<GameObject> _bulletList;
[SerializeField]private int num;
[SerializeField]private GameObject firePosition;
[SerializeField]private float curveRate;
[SerializeField]private float speed;

    // Use this for initialization

    public void Fire()
    {
        GameObject bullet 
			= Instantiate(
				_bulletList[num],
				firePosition.transform.position,
				transform.rotation);
				bullet.transform.tag = $"{transform.tag}"+".Bullet";
				bullet.transform.name = transform.name;
				bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*speed);
			bullet.GetComponent<Renderer>().material.color =
			GetComponent<Renderer>().material.color;
			bullet.GetComponent<Bullet>().bulletSpeed = speed;
			bullet.GetComponent<Bullet>().curveRate = curveRate;
    }
}
