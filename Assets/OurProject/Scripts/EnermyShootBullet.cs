using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyShootBullet : MonoBehaviour {

public List<GameObject> bulletList;
GameObject _bullet;
public GameObject firePosition;
[SerializeField]private float _speed;
	// Use this for initialization
// private enum bulletType
// {
// 	Normal,
// 	Guided,
// 	Explose,
// 	Spread,
// }
// private bulletType b;
public int num;


void Start()
{
	SetBullet();
}

    private void SetBullet()
    {_bullet = bulletList[num];
        // switch(b)
		// {
		// 	case bulletType.Normal :
		// 	_bullet = bulletList[0];
		// 	break;
		// 	case bulletType.Guided:
		// 	default:
		// 	_bullet = bulletList[1];
		// 	break;
		// 	case bulletType.Explose:
		// 	_bullet = bulletList[2];
		// 	break;
		// 	case bulletType.Spread:
		// 	_bullet = bulletList[3];
		// 	break;
		// }
    }

    public void Fire()
    {
        GameObject bullet 
			= Instantiate(
				_bullet,
				firePosition.transform.position,
				transform.rotation);
				bullet.transform.tag = $"{transform.tag}"+".Bullet";
				bullet.transform.name = transform.name;
			bullet.GetComponent<Renderer>().material.color =
			GetComponent<Renderer>().material.color;
    }
}
