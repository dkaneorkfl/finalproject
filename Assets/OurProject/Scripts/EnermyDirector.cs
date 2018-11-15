using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyDirector : MonoBehaviour {
private float _cooltime;
internal float HP;
	void Start () {
		_cooltime = 0.2f;
		HP = 10;
	}
	
	// Update is called once per frame
	void Update () {
		_cooltime -= Time.deltaTime;
		if(_cooltime<0)
		{
			_cooltime = 0.7f;
			gameObject.GetComponent<EnermyShootBullet>().Fire();
		}
		if(HP == 0)
		{
			Debug.Log("I'm Dead.");
			HP = 10;
		}
	}
}
