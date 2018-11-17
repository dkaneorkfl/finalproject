using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPIndicator : MonoBehaviour {
[SerializeField]private GameObject Player;
private float HP;
private float MaxHP;
 void Start() 
	{
		HP = Player.GetComponent<PlayerDirector>().HP;
		MaxHP = Player.GetComponent<PlayerDirector>().MaxHP;
	}

 void Update()
	{
		HP = Player.GetComponent<PlayerDirector>().HP;
		transform.localScale = new Vector3(HP / MaxHP, 1, 1);	
	}

}
