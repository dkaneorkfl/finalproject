using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirector : CharacterData {
GameObject weapon;
GameObject Shield;
[SerializeField]internal float Score;
[SerializeField]internal float MaxHP;
[SerializeField]internal float HP;
List<GameObject> ObjectList = new List<GameObject>();
	// Use this for initialization
	public virtual void Start () {
		Score = 0;
		weapon = GameObject.Find("Cylinder");
		Shield = GameObject.Find("Cube");

		ObjectList.Add(gameObject);
		ObjectList.Add(weapon);
		ObjectList.Add(Shield);

		ChangeObjcet(ObjectList, Team1, team1Color);

		MaxHP = 10;
		HP = MaxHP;
		Score = 0;
	}
	
	// Update is called once per frame
	public virtual void Update () {
		ColorChange();
		PlayerDead();
	}

    private void PlayerDead()
    {
        if(HP == 0)
		{
			Debug.Log("Player is Dead!");
			HP = 10;
			PlayerPrefs.SetFloat("ScoreSender",Score);
		}
    }

    private void ColorChange()
    {
        if(Input.GetMouseButtonDown(2))
		{
			if(transform.tag == Team1)
			{
				ChangeObjcet(ObjectList, Team2, team1Color);
			}
			else if(transform.tag == Team2)
            {
				ChangeObjcet(ObjectList, Team1, team2Color);
            }
        }
	}

    private void ChangeObjcet(List<GameObject> a, string b, Color c)
    {
		foreach (GameObject item in a)
		{
		item.transform.tag = b;
		item.GetComponent<Renderer>().material.color = c;
		}
        
    }
}
