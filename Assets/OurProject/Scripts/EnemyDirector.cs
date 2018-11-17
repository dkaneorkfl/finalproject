using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirector : CharacterData {
private float _cooltime;

public int HP;
// private enum bulletType
// {
// 	Normal,
// 	Guided,
// 	Curve,
// 	Lock,
// }

	void Start () {
		GetColor();
		_cooltime = 0.2f;
		HP = 10;
	}
	
	// Update is called once per frame
	void Update () {
		_cooltime -= Time.deltaTime;
		if(_cooltime<0)
		{
			_cooltime = 0.7f;
			gameObject.GetComponent<EnemyShootBullet>().Fire();
		}
		if(HP == 0)
		{
			Debug.Log("I'm Dead.");
			Destroy(gameObject);
		}
	}
}
